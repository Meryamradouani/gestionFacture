🧾 Application de Gestion de Facturation avec Crystal Reports
Ce projet consiste à développer une application de facturation en Windows Forms avec génération de rapports professionnels à l’aide de Crystal Reports, et gestion des données avec SQL Server et ADO.NET.

🛠 Technologies utilisées
Composant	Description
🧑‍💻 C# (.NET)	Langage principal de développement avec Windows Forms
🗃️ SQL Server	Système de gestion de base de données relationnelle
📦 ADO.NET	Bibliothèque pour la communication avec SQL Server
📊 Crystal Reports	Génération de rapports PDF (devis/factures)

🎯 Objectif du projet
Développer une application permettant :

La gestion des clients

La création de devis et factures

L’impression de rapports avec Crystal Reports

Le suivi des ventes et des documents générés

🧱 Architecture du projet
Interface utilisateur avec Windows Forms

Utilisation d’un DataSet typé pour modéliser les relations entre :

Clients

Produits

Devis

Factures

Rapports personnalisés avec Crystal Reports

Gestion de la base de données via ADO.NET

🗂️ Structure du projet
python
Copy code
TP5_Facturation_CrystalReports/
│
├── bin/                         # Exécutables compilés
├── CrystalReports/             # Rapports .rpt (devis/factures)
├── Forms/                      # Formulaires utilisateurs
├── Models/                     # Modèles des entités (Client, Produit, etc.)
├── DataSet/                    # DataSet typé et TableAdapters
├── Program.cs                  # Point d’entrée
└── TP5_Facturation.csproj      # Fichier projet
📌 Fonctionnalités principales
👥 Clients

Ajouter / modifier / supprimer un client

Rechercher un client par nom ou identifiant

📦 Produits

Ajout de produits avec prix et quantités

📄 Devis / Factures

Création de devis avec sélection de produits

Conversion devis → facture

Calcul automatique des totaux

📤 Rapports

Génération de devis/factures en PDF

Aperçu avant impression

Export PDF / Impression via Crystal Reports

🖼️ Aperçu du DataSet
Le DataSet comprend les relations suivantes :

Client (IdClient) ←→ Facture (IdClient)

Facture (IdFacture) ←→ LigneFacture (IdFacture)

Produit (IdProduit) ←→ LigneFacture (IdProduit)

![image](https://github.com/user-attachments/assets/fdaeedc4-bf0a-4a8e-bdf6-594974facd1e)
![image](https://github.com/user-attachments/assets/00cd752e-3c21-4e43-8ead-05af8cf84adc)
![image](https://github.com/user-attachments/assets/2da2e79d-09b6-4a6e-ae6b-70cef2fd297b)
![image](https://github.com/user-attachments/assets/6e838b74-0e49-4613-92bb-a2cbe6366b2c)
![image](https://github.com/user-attachments/assets/2bf6f27c-13c8-47db-8d06-aac66e8cfc8f)



