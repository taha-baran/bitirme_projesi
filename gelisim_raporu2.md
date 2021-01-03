# Gelişim Raporu II
## Düzenlemeler
### Gant Şeması
![Şema](https://i.hizliresim.com/fZysZU.png)

## Zorluklar

**Web Socket:** EMOTIV EPOC+ cihazının bilgisayar ile bağlantısını ilk denemede sağlayamadık. Bunun üzerine Emotiv Cortex V2 [^1] reposundaki *"cortex"* adlı Python dosyasından gerekli kodları kullanarak cihaza erişim sağladık.

```python
url = "wss://localhost:6868"
self.ws = websocket.create_connection(url, sslopt={"cert_reqs": ssl.CERT_NONE})
```

**Sinyallerin İşlenmesi:** Kullanıcıdan alınan beyin sinyallerinin eğitilmesi ve işlenmesi konusunda zorlandık. Bu sorunun çözümü ile uğraşmaktayız.

## Araçlar

**Uygulamalar**
* Unity
* Emotiv Pro
* EmotivBCI

**Cihazlar**
* Emotiv Epoc+
* HTC Vive Eye Pro

## İş Dağılımı
| Kişiler | Saat |
| -: | :- |
| İbrahim Şengün | %28 |
| Mehmet Alan | %27 |
| Taha Rıdvan Baran | %45 |

## Kaynaklar

[^1]:["Emotiv Cortex V2"](https://github.com/Emotiv/cortex-v2-example) . Github. Web. 23.12.2020