#pragma checksum "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0270361992830bd2648fbb531457404405769875"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Guests_Delete), @"mvc.1.0.view", @"/Areas/User/Views/Guests/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0270361992830bd2648fbb531457404405769875", @"/Areas/User/Views/Guests/Delete.cshtml")]
    public class Areas_User_Views_Guests_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WeddingAnniversary.Areas.User.Models.Guest>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Guest</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AllowedPusOne));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AllowedPusOne));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.GuestList));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.GuestList.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RSVP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RSVP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PlusOne));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PlusOne));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 58 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PlusOneName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 61 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PlusOneName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 64 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PlusOneSurname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 67 "C:\Dev\Web\2021JobPrep\WeddingSite\WeddingAnniversary\Areas\User\Views\Guests\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PlusOneSurname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    <form asp-action=\"Delete\">\r\n        <input type=\"hidden\" asp-for=\"Id\" />\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        <a asp-action=\"Index\">Back to List</a>\r\n    </form>\r\n</div>\r\n");
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
