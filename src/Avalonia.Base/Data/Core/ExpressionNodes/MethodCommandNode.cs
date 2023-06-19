﻿using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace Avalonia.Data.Core.ExpressionNodes;

/// <summary>
/// A node in an <see cref="UntypedBindingExpression"/> which converts methods to an
/// <see cref="ICommand"/>.
/// </summary>
internal class MethodCommandNode : ExpressionNode
{
    private readonly Action<object, object?> _execute;
    private readonly Func<object, object?, bool>? _canExecute;
    private readonly ISet<string> _dependsOnProperties;
    private Command? _command;

    public MethodCommandNode(
        Action<object, object?> execute,
        Func<object, object?, bool>? canExecute,
        ISet<string> dependsOnProperties)
    {
        _execute = execute;
        _canExecute = canExecute;
        _dependsOnProperties = dependsOnProperties;
    }

    protected override void OnSourceChanged(object? oldSource, object? newSource)
    {
        _command = null;

        if (newSource is not null)
        {
            _command = new Command(newSource, _execute, _canExecute);
            SetValue(_command);
        }
        else
        {
            ClearValue();
        }
    }

    private sealed class Command : ICommand
    {
        private readonly WeakReference<object?> _target;
        private readonly Action<object, object?> _execute;
        private readonly Func<object, object?, bool>? _canExecute;

        public event EventHandler? CanExecuteChanged;

        public Command(object? target, Action<object, object?> execute, Func<object, object?, bool>? canExecute)
        {
            _target = new(target);
            _execute = execute;
            _canExecute = canExecute;
        }

        public void RaiseCanExecuteChanged()
        {
            Threading.Dispatcher.UIThread.Post(() => CanExecuteChanged?.Invoke(this, EventArgs.Empty)
               , Threading.DispatcherPriority.Input);
        }

        public bool CanExecute(object? parameter)
        {
            if (_target.TryGetTarget(out var target))
            {
                if (_canExecute == null)
                {
                    return true;
                }
                return _canExecute(target, parameter);
            }
            return false;
        }

        public void Execute(object? parameter)
        {
            if (_target.TryGetTarget(out var target))
            {
                _execute(target, parameter);
            }
        }
    }

}
