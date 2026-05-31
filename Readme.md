# APPLICATION C# - ADMINISTRATION DE BASES DE DONNÉES MySQL

## 1. Description du projet
Cette application Desktop développée en C# permet l’administration de bases de données MySQL via une interface graphique.

Elle permet d’effectuer des opérations classiques de gestion de bases de données sans utiliser directement la ligne de commande SQL.

---

## 2. Technologies utilisées
- Langage : C#
- Framework : .NET WinForms 
- SGBD : MySQL
- Serveur local : WAMP Server
- Connecteur : MySql.Data

---

## 3. Fonctionnalités
- Connexion à MySQL
- Création de bases de données
- Suppression de bases de données
- Création de tables
- Modification de tables (ALTER TABLE)
- Suppression de tables
- Exécution de scripts SQL (SELECT, INSERT, UPDATE, DELETE)
- Gestion simple des opérations d’administration

---

## 4. Installation et exécution

### 4.1 Prérequis
- WAMP Server installé et démarré
- Visual Studio installé
- MySQL actif (via WAMP)
- Bibliothèque MySql.Data installée

### 4.2 Exécution du projet
1. Ouvrir le fichier solution (.sln) dans Visual Studio
2. Vérifier la connexion MySQL (localhost, root, mot de passe vide ou défini)
3. Lancer l’application (Start / F5)

---

## 5. Base de données
La base de données est gérée localement via MySQL (WAMP Server).

Nom possible : admin_db ou autre selon configuration.

---

## 6. Structure du projet
- Forms : interface utilisateur
- Classes : logique de connexion et requêtes SQL
- bin/Debug : exécutable
- Database : scripts SQL (si inclus)

---

## 7. Auteur
Nom : ANDRIAMAMPITATSOA MANDRINDRA FAHENDRENA
Classe : L3 Intégration et Développement
Année académique : 2025-2026

---

## 8. Remarques
Ce projet est limité à MySQL uniquement pour simplification mais peut être étendu à PostgreSQL et MongoDB.
