# BarcodeSkiaSharp
「[ASP.NET Core2でバーコードイメージを表示する](https://github.com/kazenetu/blog-reports/blob/master/reports/21-barcodeDotNetCore/readme.md)」のSkiaSharpバージョン

### 実行方法
1. ```dotnet run --project dotnet<version>/BarcodeSkiaSharp.csproj```を実行
   * dotnet6  
     ```dotnet run --project dotnet6/BarcodeSkiaSharp.csproj```
   * dotnet7  
     ```dotnet run --project dotnet7/BarcodeSkiaSharp.csproj```
   * dotnet8  
     ```dotnet run --project dotnet8/BarcodeSkiaSharp.csproj```

1. ブラウザで```http://localhost:5115```にアクセスする
1. QRコードに設定したい文字列を```QRコードの値```に入力  
  ![コード入力](01.png)
1. ```QRコードし直し```ボタンをクリック
1. QRコードイメージが表示される  
  ![QR表示](02.png)


### 使用パッケージ
* [SkiaSharp](https://www.nuget.org/packages/SkiaSharp)([MIT License](https://github.com/mono/SkiaSharp/blob/main/LICENSE.md))
* [SkiaSharp.NativeAssets.Linux.NoDependencies](https://www.nuget.org/packages/SkiaSharp.NativeAssets.Linux)([MIT License](https://github.com/mono/SkiaSharp/blob/main/LICENSE.md))
* [SkiaSharp.QrCode](https://www.nuget.org/packages/SkiaSharp.QrCode)([MIT License](https://github.com/guitarrapc/SkiaSharp.QrCode/blob/main/LICENSE.md))
