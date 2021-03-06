#pragma checksum "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d73eb5996d65a80d6fc24335125f70277e756f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Invitations_Create), @"mvc.1.0.view", @"/Areas/User/Views/Invitations/Create.cshtml")]
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
#nullable restore
#line 2 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\Create.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d73eb5996d65a80d6fc24335125f70277e756f6", @"/Areas/User/Views/Invitations/Create.cshtml")]
    public class Areas_User_Views_Invitations_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WeddingAnniversary.Areas.User.Models.Invitation>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/createInvitation.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""center"">
<h1>Create Invitation</h1>

<br />
<hr />
<div class=""row"">
    <div class=""col-md-4"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div style=""display: none;"" class=""form-group"">
                <label asp-for=""OwnerEmail"" class=""control-label"">OwnerEmail</label>
                <input asp-for=""OwnerEmail"" id=""OwnerEmail"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 705, "\"", 732, 1);
#nullable restore
#line 20 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\Create.cshtml"
WriteAttributeValue("", 713, User.Identity.Name, 713, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                <span asp-validation-for=""OwnerEmail"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""WeddingName"" class=""control-label"">Wedding Name</label>
                <input asp-for=""WeddingName"" id=""WeddingName"" class=""form-control"" />
                <span asp-validation-for=""WeddingName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""InvitationIntro"" class=""control-label"">Introduction</label>
                <input asp-for=""InvitationIntro"" id=""InvitationIntro"" class=""form-control"" />
                <span asp-validation-for=""InvitationIntro"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""OurStory"" class=""control-label"">Body/Story</label>
                <input asp-for=""OurStory"" id=""OurStory"" class=""form-control"" />
                <span asp-validation-for=""OurStory"" class=""te");
            WriteLiteral(@"xt-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Venue"" class=""control-label"">Venue</label>
                <input asp-for=""Venue"" id=""Venue"" class=""form-control"" />
                <span asp-validation-for=""Venue"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""VenueLocation"" class=""control-label"">Venue Location</label>
                <input asp-for=""VenueLocation"" id=""VenueLocation"" class=""form-control"" />
                <span asp-validation-for=""VenueLocation"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""VenueWebsite"" class=""control-label"">Venue Website</label>
                <input asp-for=""VenueWebsite"" id=""VenueWebsite"" class=""form-control"" />
                <span asp-validation-for=""VenueWebsite"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
        ");
            WriteLiteral(@"        <label asp-for=""WeddingDate"" class=""control-label"">Wedding Date</label>
                <input type=""date"" asp-for=""WeddingDate"" id=""WeddingDate"" class=""form-control"" />
                <span asp-validation-for=""WeddingDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""RSVPDate"" class=""control-label"">RSVP Date</label>
                <input type=""date"" asp-for=""RSVPDate"" id=""RSVPDate"" class=""form-control"" />
                <span asp-validation-for=""RSVPDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Note"" for=""Note"" class=""control-label""><input type=""checkbox"" onchange=""document.getElementById('NotesContainer').classList.toggle('hidden')"" name=""Note"" id=""Note"">&nbsp;Add Note(s)</label>
                <div class=""hidden"" id=""NotesContainer"">
                    <p>Notes &emsp;&emsp;&emsp;&emsp;&emsp; <a style=""cursor:pointer;"" id=""AddNote"">Add<st");
            WriteLiteral("rong>+</strong></a></p>\r\n                    <ul id=\"NotesOnly\">\r\n                        <li><input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 3917, "\"", 3925, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""note"" placeholder=""Note"" /></li>
                    </ul>
                </div>
            </div>
            <div class=""form-group"">
                <input type=""submit"" id=""CreateBtn"" value=""Create"" class=""btn btn-primary"">
            </div>
    </div>
</div>

<div>
    <a class=""btn btn-secondary""");
            BeginWriteAttribute("href", " href=\"", 4251, "\"", 4315, 2);
            WriteAttributeValue("", 4258, "/User/Invitations/ViewSingle?UserName=", 4258, 38, true);
#nullable restore
#line 79 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\Create.cshtml"
WriteAttributeValue("", 4296, User.Identity.Name, 4296, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Back to List</a>\r\n</div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 83 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d73eb5996d65a80d6fc24335125f70277e756f69236", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WeddingAnniversary.Areas.User.Models.Invitation> Html { get; private set; }
    }
}
#pragma warning restore 1591
