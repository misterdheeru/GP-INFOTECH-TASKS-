using gp_BALL.ServicesRepository;
using gp_DALL.Models;
using gp_DALL.Repository;
using System.IO;
using System.Net.Http;
using System.Web;
using System;
using System.Web.Http;
using System.Linq;
using System.Threading.Tasks;


namespace gp_studentscrudFileUpload.Controllers
{
    public class CountrysController : ApiController
    {
        CountrysServicesRepository objball = new CountrysServicesRepository();

        CountriesRepository objdall = new CountriesRepository();


 
        [HttpGet]
        public IHttpActionResult GetAllCountries()
        {
            var res = objball.AllCountries();
            return Ok(res);
        }

        [HttpPost]
        //public async Task<IHttpActionResult> InsertCountrys()
        //{
        //    if (!Request.Content.IsMimeMultipartContent())
        //    {
        //        return BadRequest("Unsupported media type");
        //    }

        //    var provider = new MultipartFormDataStreamProvider(Path.GetTempPath());
        //    await Request.Content.ReadAsMultipartAsync(provider);

        //    var country = new Countrys
        //    {
        //        COUNTRY_ID = int.Parse(provider.FormData["COUNTRY_ID"]),
        //        COUNTRY_CODE = provider.FormData["COUNTRY_CODE"],
        //        COUNTRY_NAME = provider.FormData["COUNTRY_NAME"],
        //        CREATED_BY = provider.FormData["CREATED_BY"],
        //        CREATED_ON = DateTime.Now.ToString(),
        //        UPDATED_BY = provider.FormData["UPDATED_BY"],
        //        UPDATED_ON = DateTime.Now.ToString(),
        //        COUNTRY_IMG_Path = provider.FormData["COUNTRY_IMG_Path"],
        //    };
        //    var file = provider.FileData.FirstOrDefault();
        //    if (file != null)
        //    {
        //        var fileInfo = new FileInfo(file.LocalFileName);
        //        var filePath = Path.Combine(HttpContext.Current.Server.MapPath("~/img"), fileInfo.Name);

        //        Directory.CreateDirectory(Path.GetDirectoryName(filePath));
        //        File.Move(file.LocalFileName, filePath);

        //        using (var memoryStream = new MemoryStream())
        //        {
        //            using (var fileStream = new FileStream(filePath, FileMode.Open))
        //            {
        //                await fileStream.CopyToAsync(memoryStream);
        //                country.COUNTRY_IMG = memoryStream.ToArray();
        //            }
        //        }

        //        country.COUNTRY_IMG_Path = fileInfo.Name;
        //    }

        //    int result = objball.insertCountryRecord(country);
        //    return Ok("RECORD IS INSERTED");
        //}
 
        public async Task<IHttpActionResult> AddFile()
        {
            string result = "";
            try
            {
                var provider = new MultipartFormDataStreamProvider(Path.GetTempPath());
                await Request.Content.ReadAsMultipartAsync(provider);

                var country = new Countrys
                {
                    COUNTRY_ID = int.Parse(provider.FormData["COUNTRY_ID"]),
                    COUNTRY_CODE = provider.FormData["COUNTRY_CODE"],
                    COUNTRY_NAME = provider.FormData["COUNTRY_NAME"],
                    CREATED_BY = "system", // Replace with actual user if necessary
                    CREATED_ON = DateTime.Now.ToString(),
                    UPDATED_BY = "system", // Replace with actual user if necessary
                    UPDATED_ON = DateTime.Now.ToString(),
                    COUNTRY_IMG_Path = provider.FormData["COUNTRY_IMG_PATH"]
                };

                var httpRequest = HttpContext.Current.Request;
                var postedImage = httpRequest.Files["COUNTRY_IMG_PATH"];

                if (postedImage != null)
                {
                    string imageName = new string(Path.GetFileNameWithoutExtension(postedImage.FileName).Take(10).ToArray()).Replace(" ", "-");
                    imageName = imageName + DateTime.Now.ToString("yymmssfff") + Path.GetExtension(postedImage.FileName);

                    var filePath = HttpContext.Current.Server.MapPath("~/img/" + imageName);
                    postedImage.SaveAs(filePath);

                    country.COUNTRY_IMG_Path = "/img/" + imageName;
                }

                int resultCode = objball.insertCountryRecord(country);
                result = resultCode > 0 ? "File uploaded successfully" : "File upload failed";
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

            return Ok(result);
        }

        [HttpPut]
        public IHttpActionResult UpdateCountrys(int ID, Countrys obj)
        {
            int i = objball.updatedCountryRecord(ID, obj);

            if (i == 1)
            {
                return Ok("RECORD IS UPDATED");
            }
            else
            {
                return Ok("RECORD IS FAILED TO  UPDATE");
            }
        }

        [HttpDelete]
        public IHttpActionResult DeleteCountrys(int ID)
        {
            int i = objball.DeleteCountryRecord(ID);

            if (i == 1)
            {
                return Ok("RECORD IS DELETED");
            }
            else
            {
                return Ok("RECORD IS FAILED TO  DELETE");
            }
        }

        [HttpGet]
        public IHttpActionResult GetSingleCountrys(int ID)
        {
            var res = objball.SingleCountrys(ID);
            return Ok(res);
        }
       
    }


}
