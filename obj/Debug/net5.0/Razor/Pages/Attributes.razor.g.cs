#pragma checksum "C:\Users\Jeremy Morgan\Repos\blazorfacerec\Pages\Attributes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c43f81b30863802b94e474214b6dfcef8dc7a90"
// <auto-generated/>
#pragma warning disable 1591
namespace blazorfacerec.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Jeremy Morgan\Repos\blazorfacerec\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jeremy Morgan\Repos\blazorfacerec\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jeremy Morgan\Repos\blazorfacerec\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Jeremy Morgan\Repos\blazorfacerec\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jeremy Morgan\Repos\blazorfacerec\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Jeremy Morgan\Repos\blazorfacerec\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Jeremy Morgan\Repos\blazorfacerec\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Jeremy Morgan\Repos\blazorfacerec\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Jeremy Morgan\Repos\blazorfacerec\_Imports.razor"
using blazorfacerec;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Jeremy Morgan\Repos\blazorfacerec\_Imports.razor"
using blazorfacerec.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jeremy Morgan\Repos\blazorfacerec\Pages\Attributes.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jeremy Morgan\Repos\blazorfacerec\Pages\Attributes.razor"
using System.Net.Mime;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Jeremy Morgan\Repos\blazorfacerec\Pages\Attributes.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/attributes")]
    public partial class Attributes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Get Attributes from Image</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<label>Image Url: </label>\r\n");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\Jeremy Morgan\Repos\blazorfacerec\Pages\Attributes.razor"
              ImageUrl

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ImageUrl = __value, ImageUrl));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Jeremy Morgan\Repos\blazorfacerec\Pages\Attributes.razor"
                   ProcessImage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Process Image");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n<br>\r\n<br>");
#nullable restore
#line 15 "C:\Users\Jeremy Morgan\Repos\blazorfacerec\Pages\Attributes.razor"
 if (_faces != null)
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Jeremy Morgan\Repos\blazorfacerec\Pages\Attributes.razor"
     foreach (var face in _faces)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "row");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-md-8");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "style", "float: left;");
            __builder.OpenElement(16, "img");
            __builder.AddAttribute(17, "src", 
#nullable restore
#line 23 "C:\Users\Jeremy Morgan\Repos\blazorfacerec\Pages\Attributes.razor"
                               ImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "height", "100");
            __builder.AddAttribute(19, "width", "100");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "style", "margin-left: 10px; float: right;");
            __builder.OpenElement(23, "ul");
            __builder.OpenElement(24, "li");
            __builder.AddMarkupContent(25, "<strong>Image ID:</strong> ");
            __builder.AddContent(26, 
#nullable restore
#line 27 "C:\Users\Jeremy Morgan\Repos\blazorfacerec\Pages\Attributes.razor"
                                                        face.FaceId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "li");
            __builder.AddMarkupContent(29, "<strong>Gender: </strong>");
            __builder.AddContent(30, 
#nullable restore
#line 28 "C:\Users\Jeremy Morgan\Repos\blazorfacerec\Pages\Attributes.razor"
                                                      face.FaceAttributes.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.OpenElement(32, "li");
            __builder.AddMarkupContent(33, "<strong>Age:</strong> ");
            __builder.AddContent(34, 
#nullable restore
#line 29 "C:\Users\Jeremy Morgan\Repos\blazorfacerec\Pages\Attributes.razor"
                                                   face.FaceAttributes.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                        ");
            __builder.OpenElement(36, "li");
            __builder.AddMarkupContent(37, "<strong>Glasses?:</strong> ");
            __builder.AddContent(38, 
#nullable restore
#line 30 "C:\Users\Jeremy Morgan\Repos\blazorfacerec\Pages\Attributes.razor"
                                                        face.FaceAttributes.Glasses

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.OpenElement(40, "li");
            __builder.AddMarkupContent(41, "<strong>Emotion:</strong> ");
            __builder.AddContent(42, 
#nullable restore
#line 31 "C:\Users\Jeremy Morgan\Repos\blazorfacerec\Pages\Attributes.razor"
                                                       face.TopEmotion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Users\Jeremy Morgan\Repos\blazorfacerec\Pages\Attributes.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Jeremy Morgan\Repos\blazorfacerec\Pages\Attributes.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\Jeremy Morgan\Repos\blazorfacerec\Pages\Attributes.razor"
       

    private readonly string _baseUrl = "https://blazorfacerec.cognitiveservices.azure.com/";
    private string ImageUrl { get; set; }
    private Face[] _tmpfaces;
    private List<Face> _faces;
    private Dictionary<string, float> _emotions;

    [Inject]
    private AppConfiguration _config { get; set; }


    private async Task ProcessImage()
    {
        _faces = null;
        _faces = new List<Face>();

        HttpClient client = new HttpClient { BaseAddress = new Uri(_baseUrl + "/face/v1.0/detect?returnFaceAttributes=age,glasses,emotion,gender&ReturnFaceLandmarks=true") };

        HttpResponseMessage response = null;

        var payload = new DataPayload { Url = ImageUrl };

        var payloadString = new StringContent(System.Text.Json.JsonSerializer.Serialize(payload), Encoding.UTF8, MediaTypeNames.Application.Json);

        client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _config.ApiKey);

        response = await client.PostAsync(client.BaseAddress, payloadString);

        if (response.Content is object && response.Content.Headers.ContentType.MediaType == "application/json")
        {
            var content = await response.Content.ReadAsStringAsync();
            _tmpfaces = JsonSerializer.Deserialize<Face[]>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            ProcessEmotions();
        }
    }

    public void ProcessEmotions()
    {
        foreach (Face face in _tmpfaces)
        {
            var emotionValues = new Dictionary<string, float> {
                {"Anger", face.FaceAttributes.Emotion.Anger},
                {"Contempt", face.FaceAttributes.Emotion.Contempt},
                {"Disgust", face.FaceAttributes.Emotion.Disgust},
                {"Fear", face.FaceAttributes.Emotion.Fear},
                {"Happiness", face.FaceAttributes.Emotion.Happiness},
                {"Neutral", face.FaceAttributes.Emotion.Neutral},
                {"Sadness", face.FaceAttributes.Emotion.Sadness},
                {"Surprise", face.FaceAttributes.Emotion.Surprise}

            };

            float topValue = 0;
            string topValueName = "";

            foreach (var emotion in emotionValues)
            {
                Console.WriteLine("Key: " + emotion.Key + "Value: " + emotion.Value);

                if (emotion.Value > topValue)
                {
                    topValue = emotion.Value;
                    topValueName = emotion.Key;
                }
            }

            Face ourFace = new Face { FaceId = face.FaceId, FaceAttributes = face.FaceAttributes, TopEmotion = topValueName };
            _faces.Add(ourFace);
        }
    }

    public class DataPayload
    {
        public string Url { get; set; }
    }

    public class Face
    {
        public Guid FaceId { get; set; }
        public FaceAttribute FaceAttributes { get; set; }
        public string TopEmotion { get; set; }
    }

    public class FaceAttribute
    {
        public string Gender { get; set; }
        public float Age { get; set; }
        public string Glasses { get; set; }
        public Emotion Emotion { get; set; }
    }

    public class Emotion
    {
        public float Anger { get; set; }
        public float Contempt { get; set; }
        public float Disgust { get; set; }
        public float Fear { get; set; }
        public float Happiness { get; set; }
        public float Neutral { get; set; }
        public float Sadness { get; set; }
        public float Surprise { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
