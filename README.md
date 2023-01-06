![alt text](https://sites.google.com/site/portcomptongjea/missions/projetpersonnelencadre-bts/gsb.jpg?attredirects=0)
# Projet C# GSB ges_AMM
Ce projet porte sur la réalisation d'une application sur la gestion de médicaments en Windows Form C# sur **Visual Studio** et **Sql Server**
## Pour commencer
Avant d'installer le projet **GSB_ges_AMM** il est important d'avoir quelque prérequis avant l'installation de ce dernier
### Pré-requis 
Quelques pré-requis sont impératifs pour installer le projet et pouvoir le développer/tester localement :
```
Visual Studio 2019 ou 2022 (avec le NuGet "System.Data.SqlClient")
Sql Server Management Studio 18
La base de données comprise dans le repositories à insérer dans SqlServer
```

Le projet est muni d'un compte pour pouvoir se connecter en tant qu'administrateur, le mot de passe étant crypté dans la base de données, voici les informations nécessaires pour se connecter a l'application :
1. Nom d'utilisateur : **User**
2. Mot de passe : **Admin1234**

## Auteur
Les auteurs ayant contribuer a se programme :
- **Michelet Max** (Chef de projet)
- **Nolle Damien** (Développeur)

## Installation
![alt text](https://i2.wp.com/leblogducodeur.fr/wp-content/uploads/2020/02/c.png?w=1200&ssl=1)
*Quelques étapes pour réaliser cette installation*
1. Cloner le repo
```
Disponible ici : https://github.com/Gooobelet/ap2_gsb_groupe3
```
2. Télécharger le script de la BDD disponible dans le repo
3. Créer une base de données dans SqlServer sous le nom de "GSB_ges_AMM"
4. Télécharger et exécuter le script afin d'avoir toute la base de données ainsi que les jeux de tests.
5. Changer le nom du serveur dans la "FormConnexion.cs" avec le nom de votre serveur SqlServer
6. Enfin, installer le NuGet System.Data.SqlClient indispensable pour le fonctionnement du projet

<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Contribution
Si vous avez une suggestion qui améliorerait cela, veuillez bifurquer le dépôt et créer une demande d'extraction. N'oubliez pas de mettre une étoile au projet ! Merci encore!
1. Créer une Branch Feature
2. Faite des Commit de vos changements
3. Faite un push de vos Branch
4. Proposer vos zméliorations à notre projet !

## Plus d'informations
Pour plus d'information concernant la création de nos trigger dans la base de données, une fiche technique à été mise dans le repo.

## Contact
Max Michelet - [@GitHub](https://github.com/Gooobelet) - [Email](micheletmax07@gmail.com)
Damien Nolle - [@GitHub](https://github.com/DNOLLE27) - [Email](damien.nolle@stadjutor.com)
Autre Projet : https://github.com/Gooobelet/AP1GARAGISTE
