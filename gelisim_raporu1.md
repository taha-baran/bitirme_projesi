# Gelişim Raporu
### Proje Özeti
Beyin bilgisayar arasındaki iletişimi kurarak oyunlardaki komutları sadece düşünerek yapabilmemizi
sağlamayı, insan-bilgisayar etkileşimini artırmayı ve oyunlarda daha fazla eğlenceyi hedeflemekteyiz. Beyin
sinyallerini toplayarak yapacağımız bu projede elektroensefalografi (EEG) teknolojisini kullanarak beyin
bilgisayar arasında bir arayüz oluşturacağız. Beyin Bilgisayar Arayüzü (BCI) yapacağımız bu işlemlerde çok
yardımcı olacak ve beyin ile bilgisayar arasında iletişimi rahat bir şekilde kullanmamıza izin verecektir.

Proje kapsamında bir adet oyun yapılacaktır. Bu oyun Erzurum tarihi kültürel mirasını tanıtacak şekilde
kullanıcıyı bilgilendirici bir oyun olacaktır. Tarihi yapılar 3-boyutlu (3B) olarak modellenecek ve sanal ortamda
gezinti (navigasyon) olanağı sağlanacaktır. Tasarlanacak bu oyun sahnesinde gezintiyi kontrol edebilmek için
EEG teknolojisi kullanılacaktır. EEG teknolojisi ile toplanan sinyaller BCI ile kontrol edilecektir. BCI arayüzünün
oyunla olan bağlantısı kurularak oyunda tanımlanmış olan hareketleri yapması sağlanacaktır.

### Proje Arka Planı
Beyin dalgaları kullanılarak oynanan oyun temasında birçok çalışma var. Bunlardan bazıları:
- World of Warcraft oyununun kontrollerini EEG ve pedallar yardımıyla oynanabilir hale getirilmiş. [Video](https://www.youtube.com/watch?v=jXpjRwPQC5Q)
- Counter-Strike benzeri bir oyunu Emotiv Epoc cihazı ile oynanabilir hale getirilmiş. .[Video](https://www.youtube.com/watch?v=TtvDIFY8Bwo)
- Unity üzerinden geliştirilen basit dinamiklere sahip bir oyunu Emotiv Epoc cihazı ile oynanabilir hale getirilmiş. [Video](https://www.youtube.com/watch?v=5jCBEIx6NSI)

Burada ki projelerin bizim yapacağımız projeden en büyük farkı sanal gerçeklik. Bizim projemiz beyin dalgaları ile birlikte aynı zamanda sanal gerçeklik gözlüğü ile oynanabilir olacak. Yani oyunu oynayacak kişi hem beyni dalgaları hem de sanal gerçeklik gözlüğü yardımıyla oynayacak.

### Kullanılacak Teknolojiler
Oyun [Unity 3D](https://unity.com) kullanılarak tasarlanacak. Beyin dalgaları için [Emotiv Epoc+](https://www.emotiv.com/epoc/) cihazı kullanılacak. Bu cihazın Unity üzerinden kullanılabilmesi için ise [Emotiv Unity Plugin](https://github.com/Emotiv/unity-plugin) kullanılacak. Sanal gerçeklik gözlüğü olarak ise HTC Vive Eye Pro kullanılacaktır. Kullanılacak cihazın Kullanılabilmesi açin [SteamVR Plugin](https://assetstore.unity.com/packages/tools/integration/steamvr-plugin-32647) kullanılacaktır.

### İş Bölümü Planlama
![Şema](https://i.hizliresim.com/FolLSA.png)

### Hedeflenen Çıktılar
Bilgisayar ortamında geliştirilecek bir oyunda Erzurum'un tarihi kültüler mirasına ait yapıların modellenmesi sonrasında oluşturulan ortamın sanal gerçeklik gözlüğü ve beyin dalgaları yardımıyla gezilebilir hale getirilmesi.
