# Gestion de Personnes - Examen Génie Logiciel | Groupe 01

## Description

Ce projet est une application Windows Forms développée en C# qui permet de gérer efficacement les informations personnelles des individus. L'application offre une interface conviviale pour la gestion des personnes, de leurs adresses, domiciles et numéros de téléphone.

## Technologies Utilisées

- Langage : C#
- IDE : Visual Studio
- Base de données : SQL Server
- Framework : .NET Framework
- Pour l'accès aux données : ADO.NET
- Pour l'impression des données : DGVPrinter

## Prérequis

- Visual Studio 2019 ou supérieur
- .NET Framework 4.8
- SQL Server 2012 ou supérieur
- Windows 10 ou supérieur

## Structure du Projet

```
Examen_GL_Groupe01/
├── 1.Classes/          # Classes métier et utilitaires
├── 2. Users Controls/  # Contrôles personnalisés
├── 3. Forms/           # Interfaces utilisateur
├── 4. Connexion/       # Gestion de la connexion à la base de données
├── Properties/         # Configuration du projet

```

## Base de Données

La base de données `gestion_personne` contient les tables suivantes :

- `personne` : Informations personnelles (id, nom, postnom, prenom, sexe)
- `adresse` : Adresses (id, quartier, commune, ville, pays)
- `domicile` : Relation entre personnes et adresses (id, id_personne, id_adresse, avenue, numero_avenue)
- `telephone` : Numéros de téléphone (id, id_personne, initial, numero)

### Scripts SQL

Les scripts de création de la base de données se trouvent dans le dossier `Database_Script/` :

- `Database.sql` : Création des tables et contraintes
- `ProcédureStockée.sql` : Procédures stockées pour les opérations complexes

## Installation

1. Cloner le repository
2. Restaurer les packages NuGet :
   ```powershell
   nuget restore Examen_GL_Groupe01.sln
   ```
3. Exécuter les scripts SQL dans l'ordre :
   - `Database.sql`
   - `ProcédureStockée.sql`
4. Configurer la chaîne de connexion dans `DataAccess.cs`
5. Compiler et exécuter le projet

## Fonctionnalités

### Gestion des Données

- Gestion complète des personnes (ajout, modification, suppression)
- Gestion des adresses avec validation
- Gestion des domiciles
- Gestion des numéros de téléphone
- Validation des données en temps réel
- Gestion des erreurs avec messages personnalisés

### Interface Utilisateur

- Interface intuitive et responsive
- Validation en temps réel des saisies
- Messages d'erreur clairs et précis
- Navigation simplifiée entre les formulaires

## Architecture

L'application suit une architecture en couches :

- **Présentation** : Windows Forms et User Controls
- **Métier** : Classes métier avec validation
- **Accès aux données** : Classes DAO avec gestion des transactions

## Contribution

1. Fork le projet
2. Créer une branche pour votre fonctionnalité (`git checkout -b feature/AmazingFeature`)
3. Commiter vos changements (`git commit -m 'Add some AmazingFeature'`)
4. Pousser vers la branche (`git push origin feature/AmazingFeature`)
5. Ouvrir une Pull Request
