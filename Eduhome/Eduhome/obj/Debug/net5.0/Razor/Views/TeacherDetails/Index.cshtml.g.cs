#pragma checksum "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\TeacherDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "069666d23bdf35d3d158fcf87e7da84e6a2a268a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TeacherDetails_Index), @"mvc.1.0.view", @"/Views/TeacherDetails/Index.cshtml")]
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
#line 1 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\_ViewImports.cshtml"
using Eduhome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\_ViewImports.cshtml"
using Eduhome.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\_ViewImports.cshtml"
using Eduhome.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\_ViewImports.cshtml"
using Eduhome.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"069666d23bdf35d3d158fcf87e7da84e6a2a268a", @"/Views/TeacherDetails/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4029453a71a7fe9e1e28dd86c5a7b18df529162c", @"/Views/_ViewImports.cshtml")]
    public class Views_TeacherDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmTeacherDetail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\TeacherDetails\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\TeacherDetails\Index.cshtml"
Write(await Component.InvokeAsync("VcBanner"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
<!-- Teacher Start -->
<div class=""teacher-details-area pt-150 pb-60"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-5 col-sm-5 col-xs-12"">
                <div class=""teacher-details-img"">
                  
                        <img");
            BeginWriteAttribute("src", " src=\"", 391, "\"", 429, 2);
            WriteAttributeValue("", 397, "img/teacher/", 397, 12, true);
#nullable restore
#line 13 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\TeacherDetails\Index.cshtml"
WriteAttributeValue("", 409, Model.Teacher.Image, 409, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"teacher\">\r\n                    \r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-7 col-sm-7 col-xs-12\">\r\n                <div class=\"teacher-details-content ml-50\">\r\n                 \r\n                        <h2>");
#nullable restore
#line 20 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\TeacherDetails\Index.cshtml"
                       Write(Model.Teacher.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <h5>");
#nullable restore
#line 21 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\TeacherDetails\Index.cshtml"
                       Write(Model.Teacher.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <h4>about me</h4>\r\n                        <p>\r\n                            ");
#nullable restore
#line 24 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\TeacherDetails\Index.cshtml"
                       Write(Model.Teacher.About);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <ul>\r\n");
#nullable restore
#line 27 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\TeacherDetails\Index.cshtml"
                              
                                string hobbie = "";


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><span>degree: </span>");
#nullable restore
#line 30 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\TeacherDetails\Index.cshtml"
                                                    Write(Model.Teacher.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                <li><span>experience: </span>");
#nullable restore
#line 31 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\TeacherDetails\Index.cshtml"
                                                        Write(Model.Teacher.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 32 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\TeacherDetails\Index.cshtml"
                                 foreach (var item in Model.Teacher.Teacher_Hobbies)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\TeacherDetails\Index.cshtml"
                                     foreach (var item1 in Model.Hobbies)
                                    {
                                        if (item.Hobbie_Id == item1.Id)
                                        {
                                            hobbie += item1.Name + " ,";
                                        }
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\TeacherDetails\Index.cshtml"
                                     

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><span>hobbies: </span>");
#nullable restore
#line 43 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\TeacherDetails\Index.cshtml"
                                                     Write(hobbie);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
            WriteLiteral("                                <li><span>faculty: </span>");
#nullable restore
#line 45 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\TeacherDetails\Index.cshtml"
                                                     Write(Model.Teacher.Faculty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
            WriteLiteral(@"
                        </ul>
                    
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-3 col-sm-4"">
                <div class=""teacher-contact"">
                    <h4>contact information</h4>
                    <p><span>mail me : </span>");
#nullable restore
#line 57 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\TeacherDetails\Index.cshtml"
                                         Write(Model.Teacher.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><span>make a call : </span>");
#nullable restore
#line 58 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\TeacherDetails\Index.cshtml"
                                             Write(Model.Teacher.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><span>skype : </span> ");
#nullable restore
#line 59 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\TeacherDetails\Index.cshtml"
                                        Write(Model.Teacher.Skype);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <ul>\r\n");
#nullable restore
#line 61 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\TeacherDetails\Index.cshtml"
                         foreach (var item in Model.Teacher.TeacherToSocials)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\TeacherDetails\Index.cshtml"
                             foreach (var item1 in Model.Teacher_Socials)
                            {
                                if (item1.Id == item.Teacher_Social_Id)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2875, "\"", 2892, 1);
#nullable restore
#line 68 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\TeacherDetails\Index.cshtml"
WriteAttributeValue("", 2882, item.Link, 2882, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <i");
            BeginWriteAttribute("class", " class=\"", 2942, "\"", 2961, 1);
#nullable restore
#line 69 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\TeacherDetails\Index.cshtml"
WriteAttributeValue("", 2950, item1.Icon, 2950, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                        </a>\r\n                                    </li>\r\n");
#nullable restore
#line 72 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\TeacherDetails\Index.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\TeacherDetails\Index.cshtml"
                             


                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </ul>
                </div>
            </div>
            <div class=""col-md-9 col-sm-8"">
                <div class=""skill-area"">
                    <h4>skills</h4>
                </div>
                <div class=""skill-wrapper"">
                    <div class=""row"">

");
#nullable restore
#line 87 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\TeacherDetails\Index.cshtml"
                             foreach (var item1 in Model.Teacher.Teacher_Skills)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\TeacherDetails\Index.cshtml"
                                 foreach (var skill in Model.Skills)
                                {
                                    if (item1.Skill_Id == skill.Id)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"col-sm-4\">\r\n                                            <div class=\"skill-bar-item\">\r\n                                                <span>");
#nullable restore
#line 95 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\TeacherDetails\Index.cshtml"
                                                 Write(skill.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                <div class=\"progress\">\r\n                                                    <div data-wow-delay=\"1.2s\" data-wow-duration=\"1.5s\"");
            BeginWriteAttribute("style", " style=\"", 4173, "\"", 4302, 11);
            WriteAttributeValue("", 4181, "width:", 4181, 6, true);
#nullable restore
#line 97 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\TeacherDetails\Index.cshtml"
WriteAttributeValue(" ", 4187, item1.Percent, 4188, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4202, "%;", 4202, 2, true);
            WriteAttributeValue(" ", 4204, "visibility:", 4205, 12, true);
            WriteAttributeValue(" ", 4216, "visible;", 4217, 9, true);
            WriteAttributeValue(" ", 4225, "animation-duration:", 4226, 20, true);
            WriteAttributeValue(" ", 4245, "1.5s;", 4246, 6, true);
            WriteAttributeValue(" ", 4251, "animation-delay:", 4252, 17, true);
            WriteAttributeValue(" ", 4268, "1.2s;", 4269, 6, true);
            WriteAttributeValue(" ", 4274, "animation-name:", 4275, 16, true);
            WriteAttributeValue(" ", 4290, "fadeInLeft;", 4291, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                                        <span class=\"text-top\">");
#nullable restore
#line 98 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\TeacherDetails\Index.cshtml"
                                                                          Write(item1.Percent);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n                                                    </div>\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n");
#nullable restore
#line 103 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\TeacherDetails\Index.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "C:\Users\FX505GT\Desktop\New folder (2)\Eduhome\Eduhome\Views\TeacherDetails\Index.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmTeacherDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
