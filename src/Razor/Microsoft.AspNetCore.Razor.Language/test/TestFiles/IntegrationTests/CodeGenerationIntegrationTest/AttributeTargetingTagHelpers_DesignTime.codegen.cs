// <auto-generated/>
#pragma warning disable 1591
namespace Microsoft.AspNetCore.Razor.Language.IntegrationTests.TestFiles
{
    #line hidden
    public class TestFiles_IntegrationTests_CodeGenerationIntegrationTest_AttributeTargetingTagHelpers_DesignTime
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::TestNamespace.PTagHelper __TestNamespace_PTagHelper;
        private global::TestNamespace.CatchAllTagHelper __TestNamespace_CatchAllTagHelper;
        private global::TestNamespace.InputTagHelper __TestNamespace_InputTagHelper;
        private global::TestNamespace.InputTagHelper2 __TestNamespace_InputTagHelper2;
        #pragma warning disable 219
        private void __RazorDirectiveTokenHelpers__() {
        ((System.Action)(() => {
#nullable restore
#line 1 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/AttributeTargetingTagHelpers.cshtml"
global::System.Object __typeHelper = "*, TestAssembly";

#line default
#line hidden
#nullable disable
        }
        ))();
        }
        #pragma warning restore 219
        #pragma warning disable 0414
        private static System.Object __o = null;
        #pragma warning restore 0414
        #pragma warning disable 1998
        public async System.Threading.Tasks.Task ExecuteAsync()
        {
            __TestNamespace_CatchAllTagHelper = CreateTagHelper<global::TestNamespace.CatchAllTagHelper>();
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
            __TestNamespace_InputTagHelper2 = CreateTagHelper<global::TestNamespace.InputTagHelper2>();
            __TestNamespace_InputTagHelper.Type = "checkbox";
            __TestNamespace_InputTagHelper2.Type = __TestNamespace_InputTagHelper.Type;
#nullable restore
#line 6 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/AttributeTargetingTagHelpers.cshtml"
__TestNamespace_InputTagHelper2.Checked = true;

#line default
#line hidden
#nullable disable
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
            __TestNamespace_InputTagHelper2 = CreateTagHelper<global::TestNamespace.InputTagHelper2>();
            __TestNamespace_CatchAllTagHelper = CreateTagHelper<global::TestNamespace.CatchAllTagHelper>();
            __TestNamespace_InputTagHelper.Type = "checkbox";
            __TestNamespace_InputTagHelper2.Type = __TestNamespace_InputTagHelper.Type;
#nullable restore
#line 7 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/AttributeTargetingTagHelpers.cshtml"
__TestNamespace_InputTagHelper2.Checked = true;

#line default
#line hidden
#nullable disable
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            __TestNamespace_PTagHelper = CreateTagHelper<global::TestNamespace.PTagHelper>();
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
