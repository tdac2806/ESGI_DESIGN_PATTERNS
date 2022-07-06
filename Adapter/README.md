# Le pattern Adapter
Le but de ce pattern est de convetir l'interface d'une classe donnée en une interface attendue par des clients afin qu'ils puissent travailler ensemble.  
En résumé, il permet de donner à une classe existante une nouvelle interface pour répondre aux besoins d'un client.

![](Img/img1.png)

**Adapteur** Classe `ComposantPdf` definit par `protected ComposantPdf outilPdf = new ComposantPdf();` dans `DocumentPdf`