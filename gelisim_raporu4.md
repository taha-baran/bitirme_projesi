# Gelişim Raporu IV
## Düzenlemeler

Unity ortamında hazırlanmış bir oyunun beyin sinyalleri ile kontrollerini ayarladık. Bir sonraki adım olarak unity ortamında Erzurum modellenmeye başlandı.

## Zorluklar
Emotiv cihazının live modda çalışırken önceden oluşturulmuş modeli kullanarak stream yaptırabiliyorduk. Ancak yapılan streami doğru bir şeklde alıp unity komutlarına entegre etme kısmında sıkıntı yaşadık. Alt kısımda eklediğimiz komutlar sayesinde bu zorluğun üstesinden geldik.
```csharp
if(property.Value[0].ToString()=="push")
{
    emotivHareket.action = 1;
}
else if (property.Value[0].ToString() == "neutral")
{
    emotivHareket.action = 0;
}
else if (property.Value[0].ToString() == "pull")
{
    emotivHareket.action = 2;
}
else if (property.Value[0].ToString() == "right")
{
    emotivHareket.action = 3;
}
else if (property.Value[0].ToString() == "left")
{
    emotivHareket.action = 4;
}
```

## Araçlar

**Uygulamalar**
* Unity
* EmotivBCI

**Cihazlar**
* Emotiv Epoc+
* HTC Vive Eye Pro

## Kaynaklar

["Emotiv Cortex V2"](https://github.com/Emotiv/cortex-v2-example) . Github. Web. 23.12.2020