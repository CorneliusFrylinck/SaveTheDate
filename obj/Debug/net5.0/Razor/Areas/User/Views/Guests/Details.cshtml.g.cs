#pragma checksum "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d48bcd7ad9e98bb764baa3fb5fadc91a43cd92c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Guests_Details), @"mvc.1.0.view", @"/Areas/User/Views/Guests/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d48bcd7ad9e98bb764baa3fb5fadc91a43cd92c6", @"/Areas/User/Views/Guests/Details.cshtml")]
    public class Areas_User_Views_Guests_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WeddingAnniversary.Areas.User.Models.Guest>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Guest</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Details.cshtml"
       Write(Html.DisplayFor(model => model.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AllowedPusOne));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Details.cshtml"
       Write(Html.DisplayFor(model => model.AllowedPusOne));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GuestList));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Details.cshtml"
       Write(Html.DisplayFor(model => model.GuestList.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RSVP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Details.cshtml"
       Write(Html.DisplayFor(model => model.RSVP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PlusOne));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Details.cshtml"
       Write(Html.DisplayFor(model => model.PlusOne));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PlusOneName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Details.cshtml"
       Write(Html.DisplayFor(model => model.PlusOneName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PlusOneSurname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Details.cshtml"
       Write(Html.DisplayFor(model => model.PlusOneSurname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2182, "\"", 2206, 1);
#nullable restore
#line 71 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Details.cshtml"
WriteAttributeValue("", 2197, Model.Id, 2197, 9, false);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WeddingAnniversary.Areas.User.Models.Guest> Html { get; private set; }
    }
}
#pragma warning restore 1591
