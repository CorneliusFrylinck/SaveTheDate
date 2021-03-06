#pragma checksum "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\ViewInvitation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a813b04bec2b5a61a26ad2f4c56d76f4b5601c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Invitations_ViewInvitation), @"mvc.1.0.view", @"/Areas/User/Views/Invitations/ViewInvitation.cshtml")]
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
#line 2 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\ViewInvitation.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a813b04bec2b5a61a26ad2f4c56d76f4b5601c6", @"/Areas/User/Views/Invitations/ViewInvitation.cshtml")]
    public class Areas_User_Views_Invitations_ViewInvitation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WeddingAnniversary.Areas.User.Models.Invitation>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/viewInvitation.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\ViewInvitation.cshtml"
  
    ViewData["Title"] = "View Invitation";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"center\">\r\n    <label class=\"hidden\" id=\"ownerEmail\">");
#nullable restore
#line 11 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\ViewInvitation.cshtml"
                                     Write(Model.OwnerEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n    <label class=\"hidden\" id=\"loggedMail\">");
#nullable restore
#line 12 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\ViewInvitation.cshtml"
                                     Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n\r\n    <h1>You have been invited to the ");
#nullable restore
#line 14 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\ViewInvitation.cshtml"
                                Write(Model.WeddingName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" wedding</h1>\r\n    <br />\r\n    <p>");
#nullable restore
#line 16 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\ViewInvitation.cshtml"
  Write(Model.InvitationIntro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 17 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\ViewInvitation.cshtml"
  Write(Model.OurStory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <div class=\"form-group hidden\">\r\n        <label class=\"invId\" id=\"invId\">");
#nullable restore
#line 19 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\ViewInvitation.cshtml"
                                   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n    </div>\r\n    <p>\r\n        Wedding Date: ");
#nullable restore
#line 22 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\ViewInvitation.cshtml"
                 Write(Model.WeddingDate.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n        RSVP Date: ");
#nullable restore
#line 25 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\ViewInvitation.cshtml"
              Write(Model.RSVPDate.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n        Venue Information:\r\n        <ul>\r\n            <li>Name: ");
#nullable restore
#line 30 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\ViewInvitation.cshtml"
                 Write(Model.Venue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 31 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\ViewInvitation.cshtml"
             if (!string.IsNullOrWhiteSpace(@Model.VenueWebsite))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>Website: <a");
            BeginWriteAttribute("href", " href=\"", 1068, "\"", 1094, 1);
#nullable restore
#line 33 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\ViewInvitation.cshtml"
WriteAttributeValue("", 1075, Model.VenueWebsite, 1075, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 33 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\ViewInvitation.cshtml"
                                                      Write(Model.VenueWebsite);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 34 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\ViewInvitation.cshtml"

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\ViewInvitation.cshtml"
             if (!string.IsNullOrWhiteSpace(@Model.VenueLocation))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>Location: ");
#nullable restore
#line 38 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\ViewInvitation.cshtml"
                         Write(Model.VenueLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 39 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\ViewInvitation.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </ul>
    </p>
    <label>Notes:</label>
    <div id=""NoteListContainer""><ul><label>No notes found</label></ul></div>
    <ul id=""SchedContainer"">
    </ul>
    <div style=""max-width: 100%; min-width: 100%;""><span><label style=""max-width: 40%; min-width: 40%;"">Guestlist:</label></span><label style=""max-width: 30%; min-width: 30%; "">&emsp;</label><span><label style=""max-width: 30%; min-width: 30%; "" class=""center"" id=""GuestCount""></label></span></div>
    <div id=""GuestListContainer""><ul><label>No RSVPs yet</label></ul></div>
    <a id=""viewRSVP"" class=""btn btn-secondary"" href=""#"">Click here to RSVP!</a>
    <a id=""copy"" class=""btn btn-info"" href=""#"">Copy link to Clipboard</a>
");
#nullable restore
#line 51 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\ViewInvitation.cshtml"
     if (User.Identity.Name == Model.OwnerEmail)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a id=\"edit\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2080, "\"", 2130, 5);
            WriteAttributeValue("", 2090, "editPage(", 2090, 9, true);
#nullable restore
#line 53 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\ViewInvitation.cshtml"
WriteAttributeValue("", 2099, Model.Id, 2099, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2108, ",", 2108, 1, true);
#nullable restore
#line 53 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\ViewInvitation.cshtml"
WriteAttributeValue(" ", 2109, User.Identity.Name, 2110, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2129, ")", 2129, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-light\" href=\"#\">Edit Page</a>\r\n");
#nullable restore
#line 54 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\ViewInvitation.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 59 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\ViewInvitation.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a813b04bec2b5a61a26ad2f4c56d76f4b5601c611217", async() => {
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
