#pragma checksum "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12056925be1c09b80447fbebdf93ba0873d1a6cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Invitations_Details), @"mvc.1.0.view", @"/Areas/User/Views/Invitations/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12056925be1c09b80447fbebdf93ba0873d1a6cf", @"/Areas/User/Views/Invitations/Details.cshtml")]
    public class Areas_User_Views_Invitations_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WeddingAnniversary.Areas.User.Models.Invitation>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Invitation</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OwnerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\Details.cshtml"
       Write(Html.DisplayFor(model => model.OwnerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.InvitationIntro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\Details.cshtml"
       Write(Html.DisplayFor(model => model.InvitationIntro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OurStory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\Details.cshtml"
       Write(Html.DisplayFor(model => model.OurStory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Schedule));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\Details.cshtml"
       Write(Html.DisplayFor(model => model.Schedule.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Venue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\Details.cshtml"
       Write(Html.DisplayFor(model => model.Venue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VenueLocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\Details.cshtml"
       Write(Html.DisplayFor(model => model.VenueLocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VenueWebsite));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\Details.cshtml"
       Write(Html.DisplayFor(model => model.VenueWebsite));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.WeddingDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\Details.cshtml"
       Write(Html.DisplayFor(model => model.WeddingDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RSVPDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\Details.cshtml"
       Write(Html.DisplayFor(model => model.RSVPDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2224, "\"", 2248, 1);
#nullable restore
#line 71 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Invitations\Details.cshtml"
WriteAttributeValue("", 2239, Model.Id, 2239, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WeddingAnniversary.Areas.User.Models.Invitation> Html { get; private set; }
    }
}
#pragma warning restore 1591
