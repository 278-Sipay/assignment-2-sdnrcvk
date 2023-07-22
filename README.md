
# Patika.dev | Sipay .Net Bootcamp | Lesson Homeworks | Assignment-2

# 📋 Ders Ödevleri

Hafta 2 - TransactionController üzerinde bir tane GetByParameter apisi hazırlandı. AccountNumber, MinAmountCredit, MaxAmountCredit, MinAmountDebit, MaxAmountDebit, Description, BeginDate, EndDate ve ReferenceNumber filtre kriterleri query parameter olarak eklendi. IRepository, Repository katmanlarında bu kriterleri dinamik olarak parametre verebileceğimiz bir fonksiyon hazırlandı. ITransactionRepository ve TransactionRepository'de eklemeler yapıldı.

# 📋 Lesson Homeworks

Week 2 - A GetByParameter api was created on TransactionController. AccountNumber, MinAmountCredit, MaxAmountCredit, MinAmountDebit, MaxAmountDebit, Description, BeginDate, EndDate and ReferenceNumber filter criteria have been added as query parameters. A function has been prepared in IRepository, Repository layers where we can dynamically parameterize these criteria. Additions have been made in ITransactionRepository and TransactionRepository.

# 🗂️ Klasör ve Dosya Yapısı

📂**`Repository`**  
&nbsp;📂**`Base`**

&nbsp;&nbsp;📃[IGenericRepository.cs](https://github.com/278-Sipay/assignment-2-sdnrcvk/blob/main/SipayApi/SipayApi.Data/Repository/Base/IGenericRepository.cs)   
&nbsp;&nbsp;📃[GenericRepository.cs](https://github.com/278-Sipay/assignment-2-sdnrcvk/blob/main/SipayApi/SipayApi.Data/Repository/Base/GenericRepository.cs)

&nbsp;📂**`Transaction`**

&nbsp;&nbsp;📃[ITransactionRepository.cs](https://github.com/278-Sipay/assignment-2-sdnrcvk/blob/main/SipayApi/SipayApi.Data/Repository/Transaction/ITransactionRepository.cs)   
&nbsp;&nbsp;📃[TransactionRepository.cs](https://github.com/278-Sipay/assignment-2-sdnrcvk/blob/main/SipayApi/SipayApi.Data/Repository/Transaction/TransactionRepository.css)

📂**`Controllers`**  

&nbsp;&nbsp;📃[TransactionController.cs](https://github.com/278-Sipay/assignment-2-sdnrcvk/blob/main/SipayApi/SipayApi.Service/Customer/TransactionController.cs)  

# 📎 Ek Bilgiler

## 🔗 Auto Mapper Nedir?

Auto Mapper, .NET platformunda sıkça kullanılan bir nesne eşleştirme (object mapping) kütüphanesidir. Amacı, farklı tiplerdeki nesneler arasında veri taşıma işlemlerini kolaylaştırmaktır. Özellikle veritabanından veya başka bir veri kaynağından alınan verileri, DTO'lar (Data Transfer Object) veya ViewModel sınıflarına dönüştürme gibi senaryolarda kullanılır.

Auto Mapper, manuel olarak bir nesneyi başka bir nesneyle eşleştirmenin zaman alıcı ve hata yapmaya meyilli süreçlerini otomatikleştirir. Aynı zamanda geliştiricilere daha temiz ve sade kod yazma imkanı sağlar.

Temel olarak, kaynaktaki (source) bir nesnenin, hedefteki (destination) bir nesneye belirli kural ve eşleştirme yapılarını kullanarak otomatik olarak dönüştürülmesini sağlar. Bu sayede geliştiriciler, nesne dönüşüm işlemleri için tekrarlayıcı ve zaman kaybettiren kodları yazmak yerine Auto Mapper ile verileri daha verimli bir şekilde aktarabilirler.

## 💻 Entity Framework Nedir?

Entity Framework (EF), Microsoft tarafından geliştirilen, .NET platformunda kullanılan bir ORM (Object-Relational Mapping) aracıdır. Amacı, ilişkisel veritabanlarındaki verileri nesne yönelimli bir şekilde manipüle etmeyi ve veritabanı işlemlerini kolaylaştırmayı sağlamaktır.

Geleneksel olarak, .NET uygulamalarında veritabanı işlemleri için SQL (Structured Query Language) kullanılır ve verilerin tablolara eklenmesi, güncellenmesi, silinmesi ve sorgulanması için doğrudan SQL sorguları yazmak gerekir. Bu, kodun karmaşık ve bakımı zor olmasına neden olabilir.

Entity Framework, bu zorluğu aşmak ve .NET geliştiricilerine daha kolay ve verimli bir yol sunmak için geliştirilmiştir. Temel olarak, EF, veritabanı tablolarını .NET sınıflarıyla eşleştirerek ve nesne yönelimli bir yaklaşım kullanarak veritabanı işlemlerini yönetir.

EF'nin temel özellikleri şunlardır:

Nesne Yönelimli Tasarım: Veritabanı tablolarını .NET sınıfları ile temsil eder ve verileri nesne olarak ele alır. Bu sayede verileri sorgulamak ve manipüle etmek için SQL yerine LINQ (Language Integrated Query) kullanabilirsiniz.

Code First ve Database First Yaklaşımları: EF, "Code First" ve "Database First" olmak üzere iki farklı yaklaşım sunar. Code First, .NET sınıflarını oluşturarak veritabanı şemasını otomatik oluşturmanıza olanak tanırken, Database First, varolan bir veritabanı şemasını kullanarak .NET sınıflarını oluşturmanıza olanak tanır.

LINQ Entegrasyonu: LINQ sorgularını destekleyerek, verileri veritabanından çekmek ve sorgulamak için güçlü bir dil desteği sağlar.

Otomatik Veri Yönetimi: EF, veritabanındaki verilerin değişikliklerini takip eder ve otomatik olarak uygun veritabanı işlemlerini gerçekleştirir. Yani, veri eşitlemeyle uğraşmanıza gerek kalmaz.

Veritabanı Bağımsızlığı: EF, farklı veritabanı motorlarını (SQL Server, MySQL, Oracle vb.) destekleyerek, uygulamanızın farklı veritabanlarıyla çalışmasını kolaylaştırır.

## ⚙️ LINQ Nedir?

LINQ (Language Integrated Query), Microsoft tarafından .NET platformunda tanıtılan ve .NET dillerine (C#, Visual Basic, vb.) entegre edilmiş bir sorgulama dilidir. LINQ, veri sorgulamayı ve manipüle etmeyi daha kolay, güvenli ve okunabilir hale getirmek için kullanılır.

LINQ, nesne koleksiyonları, veritabanı tabloları, XML dosyaları gibi veri kaynakları üzerinde yapılan sorgulamaları dilin doğal yapısına entegre eder. Böylece veri tabanlı işlemler için ayrı bir sorgu dili kullanmak yerine, .NET kodlarını içinde sorguları yazabilirsiniz. LINQ sorguları, tip güvenliğine sahiptir ve derleme zamanında hataların tespit edilmesine olanak tanır.

LINQ'in temel özellikleri şunlardır:

Dil Entegrasyonu: LINQ, C# ve Visual Basic gibi .NET dillerine doğrudan entegre edilmiştir. Bu sayede LINQ sorgularını .NET kodunuzun içinde rahatlıkla yazabilirsiniz.

Nesne Sorgulama: LINQ, nesne koleksiyonları üzerinde sorgulamalar yapmanıza olanak sağlar. Bir liste, dizi veya koleksiyon üzerinde LINQ kullanarak elemanları filtreleyebilir, sıralayabilir ve dönüştürebilirsiniz.

Veritabanı Sorgulama: LINQ to SQL veya Entity Framework gibi ORM araçları ile birlikte kullanılarak, veritabanı tabloları üzerinde sorgular yazmanızı sağlar. Bu sayede SQL sorgularını LINQ sorguları olarak ifade edebilir ve veritabanı işlemlerini .NET kodları içinde daha rahat bir şekilde yönetebilirsiniz.

XML ve LINQ to XML: LINQ, XML dosyaları üzerinde sorgulamalar yapmak için de kullanılabilir. XML verilerini LINQ to XML kullanarak sorgulayabilir ve dönüştürebilirsiniz.

## Badges

Add badges from somewhere like: [shields.io](https://shields.io/)

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
[![GPLv3 License](https://img.shields.io/badge/License-GPL%20v3-yellow.svg)](https://opensource.org/licenses/)
[![AGPL License](https://img.shields.io/badge/license-AGPL-blue.svg)](http://www.gnu.org/licenses/agpl-3.0)

