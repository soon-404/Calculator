#pragma checksum "C:\Users\Admin\Desktop\Calculator_0336\Calculator_0336\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cec8b7be95153049fdbd41a22bad40036ca0ae0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Admin\Desktop\Calculator_0336\Calculator_0336\Views\_ViewImports.cshtml"
using Calculator_0336;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\Calculator_0336\Calculator_0336\Views\_ViewImports.cshtml"
using Calculator_0336.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cec8b7be95153049fdbd41a22bad40036ca0ae0", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a9fa0454d20b66436193c91b6092b2c0e130b50", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("include", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/css/site.min.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("exclude", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 1019, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "967723c454d44afcbf3e73640a10e1a9", async() => {
                BeginContext(31, 121, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
                EndContext();
                BeginContext(153, 17, false);
#line 6 "C:\Users\Admin\Desktop\Calculator_0336\Calculator_0336\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(170, 595, true);
                WriteLiteral(@" - Calculator_0336</title>
    <script>
        var xmlhttp = new XMLHttpRequest();
        function MakeReq(serverpage, objID) {
            let obj = document.getElementById(objID);
            xmlhttp.open(""GET"", serverpage);
            xmlhttp.onreadystatechange = function () {
                if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                    obj.innerHTML = xmlhttp.responseText;
                    textInput = document.getElementById(objID).innerHTML;
                }
            }
            xmlhttp.send(null);
        }
    </script>
    ");
                EndContext();
                BeginContext(765, 122, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b49ff1a7993049b093e76dcaa245e560", async() => {
                    BeginContext(800, 20, true);
                    WriteLiteral("\r\n        \r\n        ");
                    EndContext();
                    BeginContext(820, 47, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b2055d6acfdc4be6bab45092db99654d", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(867, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Include = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(887, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(893, 142, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc894d80251e4a7388a2d7283cda9acd", async() => {
                    BeginContext(928, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(938, 77, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "69495eec230749e0b4334606172fd34a", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 26 "C:\Users\Admin\Desktop\Calculator_0336\Calculator_0336\Views\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1015, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Exclude = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1035, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1044, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1046, 7115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c531c10f2b52461d9ff33f57e0b0c29f", async() => {
                BeginContext(1052, 42, true);
                WriteLiteral("\r\n    <div class=\"body-content\">\r\n        ");
                EndContext();
                BeginContext(1095, 12, false);
#line 31 "C:\Users\Admin\Desktop\Calculator_0336\Calculator_0336\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1107, 7047, true);
                WriteLiteral(@"
        <fieldset class=""calContainer"">
            <legend class=""textHeader"">Basic Calculator</legend>
            <div class=""inputBox"">
                <p class=""inputText"" id=""numText""></p>
                <script>
                    document.getElementById(""numText"").innerHTML = ""Enter Number"";
                </script>
            </div>

            <script>
                var textInput = """"
                function put0() {
                    textInput += ""0""
                    document.getElementById(""numText"").innerHTML = textInput;
                }
                function put1() {
                    textInput += ""1""
                    document.getElementById(""numText"").innerHTML = textInput;
                }
                function put2() {
                    textInput += ""2""
                    document.getElementById(""numText"").innerHTML = textInput;
                }
                function put3() {
                    textInput += ""3""
                    ");
                WriteLiteral(@"document.getElementById(""numText"").innerHTML = textInput;
                }
                function put4() {
                    textInput += ""4""
                    document.getElementById(""numText"").innerHTML = textInput;
                }
                function put5() {
                    textInput += ""5""
                    document.getElementById(""numText"").innerHTML = textInput;
                }
                function put6() {
                    textInput += ""6""
                    document.getElementById(""numText"").innerHTML = textInput;
                }
                function put7() {
                    textInput += ""7""
                    document.getElementById(""numText"").innerHTML = textInput;
                }
                function put8() {
                    textInput += ""8""
                    document.getElementById(""numText"").innerHTML = textInput;
                }
                function put9() {
                    textInput += ""9""
                  ");
                WriteLiteral(@"  document.getElementById(""numText"").innerHTML = textInput;
                }
                function putAdd() {
                    textInput += "" + ""
                    document.getElementById(""numText"").innerHTML = textInput;
                }
                function putSub() {
                    textInput += "" - ""
                    document.getElementById(""numText"").innerHTML = textInput;
                }
                function putMultiply() {
                    textInput += "" * ""
                    document.getElementById(""numText"").innerHTML = textInput;
                }
                function putDevide() {
                    textInput += "" / ""
                    document.getElementById(""numText"").innerHTML = textInput;
                }
                function putDot() {
                    textInput += "".""
                    document.getElementById(""numText"").innerHTML = textInput;
                }
                function putClear() {
                    text");
                WriteLiteral(@"Input = """"
                    document.getElementById(""numText"").innerHTML = ""Enter Number"";
                }
                function putEqual() {
                    console.log(textInput.length - 1);
                    var lastChar = textInput[textInput.length - 1];
                    if (lastChar == "" "" || lastChar == ""."") {
                        alert(""Error input!"");
                    }
                    else {
                        MakeReq('http://localhost:5000/Home/Calculate/?number=' + textInput.replace('+', '%2B'), 'numText'); return false;
                    }
                }
            </script>
            <div class=""grid-container"">
                <div class=""grid-item"">
                    <button class=""buttonCal"" onclick=""put1()"">
                        1
                    </button>
                </div>
                <div class=""grid-item"">
                    <button class=""buttonCal"" onclick=""put2()"">
                        2
               ");
                WriteLiteral(@"     </button>
                </div>
                <div class=""grid-item"">
                    <button class=""buttonCal"" onclick=""put3()"">
                        3
                    </button>
                </div>
                <div class=""grid-item"">
                    <button class=""buttonCal"" onclick=""putAdd()"">
                        +
                    </button>
                </div>
                <div class=""grid-item"">
                    <button class=""buttonCal"" onclick=""put4()"">
                        4
                    </button>
                </div>
                <div class=""grid-item"">
                    <button class=""buttonCal"" onclick=""put5()"">
                        5
                    </button>
                </div>
                <div class=""grid-item"">
                    <button class=""buttonCal"" onclick=""put6()"">
                        6
                    </button>
                </div>
                <div class=""grid-item"">
 ");
                WriteLiteral(@"                   <button class=""buttonCal"" onclick=""putSub()"">
                        -
                    </button>
                </div>
                <div class=""grid-item"">
                    <button class=""buttonCal"" onclick=""put7()"">
                        7
                    </button>
                </div>
                <div class=""grid-item"">
                    <button class=""buttonCal"" onclick=""put8()"">
                        8
                    </button>
                </div>
                <div class=""grid-item"">
                    <button class=""buttonCal"" onclick=""put9()"">
                        9
                    </button>
                </div>
                <div class=""grid-item"">
                    <button class=""buttonCal"" onclick=""putMultiply()"">
                        *
                    </button>
                </div>
                <div class=""grid-item"">
                    <button class=""buttonCal"" onclick=""put0()"">
           ");
                WriteLiteral(@"             0
                    </button>
                </div>
                <div class=""grid-item"">
                    <button class=""buttonCal"" onclick=""putDot()"">
                        .
                    </button>
                </div>
                <div class=""grid-item"">
                    <button class=""buttonCal"" onclick=""putEqual()"">
                        =
                    </button>
                </div>
                <div class=""grid-item"">
                    <button class=""buttonCal"" onclick=""putDevide()"">
                        /
                    </button>
                </div>
                <div class=""grid-item-clear"">
                    <button class=""buttonClear"" onclick=""putClear()"">
                        CLEAR
                    </button>
                </div>
            </div>
        </fieldset>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8161, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591