//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     GenAPI Version: 7.0.8.6004
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Avalonia.Headless.XUnit
{
    [System.AttributeUsageAttribute(System.AttributeTargets.Method, AllowMultiple=false)]
    [Xunit.Sdk.XunitTestCaseDiscovererAttribute("Avalonia.Headless.XUnit.AvaloniaUIFactDiscoverer", "Avalonia.Headless.XUnit")]
    public sealed partial class AvaloniaFactAttribute : Xunit.FactAttribute
    {
        public AvaloniaFactAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, AllowMultiple=false)]
    [Xunit.Sdk.TestFrameworkDiscovererAttribute("Avalonia.Headless.XUnit.AvaloniaTestFrameworkTypeDiscoverer", "Avalonia.Headless.XUnit")]
    public sealed partial class AvaloniaTestFrameworkAttribute : System.Attribute, Xunit.Sdk.ITestFrameworkAttribute
    {
        public AvaloniaTestFrameworkAttribute() { }
    }
    public partial class AvaloniaTestFrameworkTypeDiscoverer : Xunit.Sdk.ITestFrameworkTypeDiscoverer
    {
        public AvaloniaTestFrameworkTypeDiscoverer(Xunit.Abstractions.IMessageSink _) { }
        public System.Type GetTestFrameworkType(Xunit.Abstractions.IAttributeInfo attribute) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method, AllowMultiple=false)]
    [Xunit.Sdk.XunitTestCaseDiscovererAttribute("Avalonia.Headless.XUnit.AvaloniaTheoryDiscoverer", "Avalonia.Headless.XUnit")]
    public sealed partial class AvaloniaTheoryAttribute : Xunit.TheoryAttribute
    {
        public AvaloniaTheoryAttribute() { }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public partial class AvaloniaTheoryDiscoverer : Xunit.Sdk.TheoryDiscoverer
    {
        public AvaloniaTheoryDiscoverer(Xunit.Abstractions.IMessageSink diagnosticMessageSink) : base (default(Xunit.Abstractions.IMessageSink)) { }
        protected override System.Collections.Generic.IEnumerable<Xunit.Sdk.IXunitTestCase> CreateTestCasesForDataRow(Xunit.Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions, Xunit.Abstractions.ITestMethod testMethod, Xunit.Abstractions.IAttributeInfo theoryAttribute, object[] dataRow) { throw null; }
        protected override System.Collections.Generic.IEnumerable<Xunit.Sdk.IXunitTestCase> CreateTestCasesForTheory(Xunit.Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions, Xunit.Abstractions.ITestMethod testMethod, Xunit.Abstractions.IAttributeInfo theoryAttribute) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public partial class AvaloniaUIFactDiscoverer : Xunit.Sdk.FactDiscoverer
    {
        public AvaloniaUIFactDiscoverer(Xunit.Abstractions.IMessageSink diagnosticMessageSink) : base (default(Xunit.Abstractions.IMessageSink)) { }
        protected override Xunit.Sdk.IXunitTestCase CreateTestCase(Xunit.Abstractions.ITestFrameworkDiscoveryOptions discoveryOptions, Xunit.Abstractions.ITestMethod testMethod, Xunit.Abstractions.IAttributeInfo factAttribute) { throw null; }
    }
}