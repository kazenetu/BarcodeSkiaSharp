using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BarcodeSkiaSharp.Models;
using SkiaSharp;
using SkiaSharp.QrCode.Image;

namespace BarcodeSkiaSharp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    /// <summary>
    /// QRコードイメージを取得
    /// </summary>
    /// <param name="data">QRイメージ</param>
    /// <returns>QRコードイメージ</returns>
    public IActionResult GetQRImage(string data)
    {
        //QRコード画像の大きさを指定(pixel)
        int size = 200;

        try
        {
            var qrCode = new QrCode(data, new Vector2Slim(size, size), SKEncodedImageFormat.Png);
            using (MemoryStream ms = new MemoryStream())
            {
                // QRをメモリ上に展開
                qrCode.GenerateImage(ms);

                // save to stream as PNG
                return File(ms.GetBuffer(), "image/png");
            }
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
