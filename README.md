# ⚡Not Hesaplama Uygulaması⚡
<p>Bu uygulama, üniversite öğrencilerinin akademik hayatlarını kolaylaştırmak amacıyla özel olarak tasarlanmış, kullanıcı dostu bir not hesaplama aracıdır. Geliştirilen bu yazılım sayesinde, vize, final ve isteğe bağlı olarak ekleyebileceğiniz ödev notlarınızı sisteme girerek ders ortalamalarınızı hızlı ve zahmetsiz bir şekilde hesaplayabilirsiniz. Artık, bir dersi geçmek için almanız gereken minimum notu bulmak veya dönem sonu not ortalamanızı tahmin etmek gibi karmaşık ve zaman alıcı hesaplamalarla uğraşmanıza gerek kalmayacak. Uygulama, size anında ve doğru sonuçlar sunarak akademik sürecinizdeki belirsizlikleri ortadan kaldırır. Bu sayede, notlarınızı takip etmek, hangi derse ne kadar ağırlık vermeniz gerektiğini belirlemek ve hatta gelecekteki notlarınızı planlamak için güçlü bir araca sahip olacaksınız. Amacımız, öğrencilerin dersleriyle ilgili not kaygılarını azaltarak, eğitimlerine daha fazla odaklanmalarına yardımcı olmaktır.</p>
<p>Üniversite öğrencileri için hazırlamış olduğum vize ve final notlarını girerek ders ortalamalarını hızlı bir şekilde hesaplamalarını sağlayacak bir uygulamadır.</p>

# 💻 Kullanılan Teknolojiler ve Araçlar
- <b>C# Programlama Dili:</b> Projenin tüm arka plan mantığı ve işleyişi C# ile kodlanmıştır. C#, Microsoft tarafından geliştirilen modern, nesne yönelimli ve tip güvenli bir programlama dilidir. Özellikle Windows masaüstü uygulamaları geliştirmek için yaygın olarak kullanılır.
- <b>Windows Forms (WinForms) veya WPF (Windows Presentation Foundation):</b> Hesap makinesinin görsel arayüzünü (düğmeler, metin kutuları, ekran vb.) oluşturmak için büyük olasılıkla Windows Forms veya WPF kullanılmıştır.
- <b>Windows Forms:</b> Daha eski ve basit masaüstü uygulamaları için tercih edilen bir UI framework'üdür. Hızlı prototipleme ve kolay sürükle bırak arayüz tasarımı sunar.
- <b>WPF:</b> Daha modern ve esnek bir UI framework'üdür. XAML (Extensible Application Markup Language) kullanarak zengin ve görsel açıdan etkileyici arayüzler oluşturmaya olanak tanır. Projenin karmaşıklığına ve arayüz beklentilerine göre bu ikisinden biri seçilmiş olabilir.
- <b>Visual Studio:</b> Projenin geliştirildiği entegre geliştirme ortamı (IDE) muhtemelen Microsoft Visual Studio'dur. Visual Studio, C# kod yazımı, hata ayıklama, arayüz tasarımı ve proje yönetimi için kapsamlı araçlar sunar.

# 🧙‍♂️ Nasıl Kullanılır?
### 1.Adım: Uygulamayı İndirme ve Başlatma
- <p>İlk adım olarak, "Not Hesaplama Uygulaması.exe" dosyasını bilgisayarınıza indirmeniz gerekmektedir. Bu dosyayı GitHub deponuzdan kolayca temin edebilirsiniz. İndirme işlemi tamamlandığında, indirilen bu çalıştırılabilir dosyaya çift tıklayarak uygulamayı başlatın. Uygulama, kullanıma hazır bir pencereyle karşınıza gelecektir.</p>
<br>
<img width="300" height="300" src="https://github.com/StarLordBerke4/Not-Hesaplama-Uygulamasi/blob/master/G%C3%B6rseller/1.png">

### 2.Adım: Not Etki Oranlarını Ayarlama
- <p>Uygulama açıldığında, vize, final ve ödev notlarının ders ortalamasına etki oranlarını belirlemeniz gerekecek.</p>
- <p>Otomatik Ayarlama: Eğer okuduğunuz üniversitenin not etki oranları, uygulamanın varsayılan ayarlarıyla (senin üniversitenin sistemine göre ayarlanmış) uyumluysa, pencerede yer alan "oto" butonuna basmanız yeterlidir. Bu sayede, vize, final ve ödev notlarının etki oranları otomatik olarak yüklenecektir.</p>
<br>
<img width="1000" height="600" src="https://github.com/StarLordBerke4/Not-Hesaplama-Uygulamasi/blob/master/G%C3%B6rseller/2.png">

- <p>Manuel Ayarlama: Eğer üniversitenizin notlandırma sistemi farklıysa, etki oranlarını manuel olarak da girebilirsiniz. Bunun için ilgili alanlara kendi üniversitenizin belirlediği yüzde oranlarını (% olarak) yazmanız yeterlidir. Örneğin, vize %40, final %60 gibi.</p>
<br>
<img width="1000" height="600" src="https://github.com/StarLordBerke4/Not-Hesaplama-Uygulamasi/blob/master/G%C3%B6rseller/3.png">
<br>

- <p><b>Not:</b> Uygulamadaki otomatik etki oranları, geliştiricinin okuduğu üniversite sistemine göre ayarlanmıştır. Kendi üniversitenizin notlandırma sistemini teyit ederek manuel giriş yapmanız, en doğru sonucu almanızı sağlayacaktır. Ödev etki oranı varsayılan olarak "0" bırakılmıştır, çünkü geliştiricinin üniversitesinde ödev notu uygulaması bulunmamaktadır. Eğer sizin derslerinizde ödev notları ortalamayı etkiliyorsa, bu değeri kendi ihtiyacınıza göre ayarlayabilirsiniz.</p>

### 3.Adım: Notları Girme ve Ortalamayı Hesaplama
- <p>Etki oranlarını ayarladıktan sonra, ilgili "not" bölümlerine vize, final ve varsa ödev notlarınızı 100'lük sistem üzerinden girin. Örneğin, vizeden 75, finalden 80 aldıysanız bu değerleri ilgili kutucuklara yazın. Tüm notları girdikten sonra "göster" butonuna tıklayın. Uygulama, girdiğiniz notları ve ayarladığınız etki oranlarını kullanarak ders ortalamanızı anında hesaplayacak ve size sunacaktır. Böylece, dersi geçip geçmediğinizi veya ortalamanızın kaç olduğunu hızlıca öğrenebilirsiniz.</p>
<br>
<img width="1000" height="600" src="https://github.com/StarLordBerke4/Not-Hesaplama-Uygulamasi/blob/master/G%C3%B6rseller/4.png">
<br>
<img width="1000" height="600" src="https://github.com/StarLordBerke4/Not-Hesaplama-Uygulamasi/blob/master/G%C3%B6rseller/5.png">

# 👾 Uygulamayı Nasıl İndirebilirim?
- <p>Not Hesaplama Uygulamasını indirmek oldukça kolaydır. Uygulamayı edinmek için projenin GitHub deposuna gitmeniz ve burada bulunan "NotHesaplamaUygulaması.exe" dosyasını indirmeniz yeterlidir. Bu tek bir çalıştırılabilir dosya olduğu için herhangi bir kurulum yapmanıza gerek kalmadan, indirme işlemi bittikten hemen sonra kullanmaya başlayabilirsiniz.</p>
<br>
<img width="1000" height="600" src="https://github.com/StarLordBerke4/Not-Hesaplama-Uygulamasi/blob/master/G%C3%B6rseller/6.png">
