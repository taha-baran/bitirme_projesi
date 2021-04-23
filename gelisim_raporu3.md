# Gelişim Raporu III
## Düzenlemeler

Emotiv-Unity ile bağlantısını kolaylaştırmak için Python kodları yerine C# kodları kullanılmaya başlandı. C# kodları Unity üzerinde uyumlu çalışabilmesi için düzenlenmektedir.

## Zorluklar

**EEG Cihazının Stream Yapması**
EEG cihazının stream yapması için [^1] reposundaki C# kodlarına alttaki **getSignals** metodunu ekledik.

```csharp
public void getSignals()
{
    // Subscribe com
    List<string> stream = new List<string>() { "com" };
    _ctxClient.Subscribe(_cortexToken, _sessionId, stream);
}
```
**Unity İçin Kodların Düzenlenmesi**
Çalışmaların Unity üzerinde devam edebilmesi için kodların düzenlenmesi gerekiyordu. Bu düzenlemeler devam etmektedir.


## Araçlar

**Uygulamalar**
* Unity
* Emotiv Pro
* EmotivBCI

**Cihazlar**
* Emotiv Epoc+
* HTC Vive Eye Pro

## Kaynaklar

[^1]:["Emotiv Cortex V2"](https://github.com/Emotiv/cortex-v2-example) . Github. Web. 23.12.2020