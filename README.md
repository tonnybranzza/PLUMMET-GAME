# Plummet Game

## Description du Jeu

Plummet Game est une adaptation du jeu *Fall Game* où le joueur contrôle un personnage se déplaçant sur un tableau de la gauche vers la droite. L'objectif est de franchir des obstacles sous forme de murs qui peuvent être détruits en cas de collision. Chaque fois qu'un joueur entre en contact avec un mur, une collision est détectée et la barre d'énergie du joueur diminue. À la fin de la partie, le score du joueur est déterminé par plusieurs facteurs : le nombre de collisions, le nombre de murs restants et la quantité d'énergie restante. Le jeu propose également un mode AI où l'ordinateur peut prendre le contrôle du personnage et naviguer sur le terrain en utilisant un algorithme de recherche de chemin (Dijkstra).

## Hiérarchie des Classes

La hiérarchie des classes du projet est organisée autour des principaux éléments du jeu : le joueur, les portes, la gestion des portes, et la caméra.

- **CameraPosition** : Gère la position de la caméra, assurant que la caméra suive toujours le joueur sur le plan horizontal et vertical.
  
- **Dijkstra** : Contient l'algorithme de recherche de chemin pour aider à la navigation du personnage, particulièrement utile en mode AI. Il permet de trouver le chemin optimal entre la position actuelle du joueur et la cible, en prenant en compte les obstacles.

- **Door** : Représente une porte dans le jeu, avec des composants physiques attachés à elle (comme les éléments du haut et du bas de la porte). Elle peut être soit une porte réelle (avec un comportement dynamique) soit une porte factice (statique).

- **DoorManager** : Gère toutes les portes présentes dans le jeu. Elle s'assure que certaines portes soient factices, en choisissant aléatoirement des portes à rendre fausses pour tromper le joueur.

- **Player** : Gère les mouvements du joueur. Le joueur peut se déplacer manuellement ou en mode AI. Si le mode AI est activé, l'algorithme de Dijkstra est utilisé pour guider le joueur. La classe suit également les collisions et la progression du joueur (nombre de collisions, nombre de pas).

- **PlayerData** : Gère les données du joueur, comme son nom de tag, le nombre de collisions et d'étapes parcourues. Elle fournit des méthodes pour sérialiser et désérialiser ces données, ainsi que pour les enregistrer ou les récupérer depuis une source externe.

Les classes sont interconnectées comme suit :
- **Player** interagit avec **PlayerData** pour gérer les statistiques du joueur et avec **Dijkstra** pour le mode AI.
- **DoorManager** et **Door** gèrent les portes du jeu, avec des interactions dynamiques et statiques.
- **CameraPosition** assure un suivi en temps réel du joueur pendant la partie.

Cette architecture permet de séparer clairement les responsabilités de chaque classe, facilitant ainsi l'entretien et l'évolution du projet.

## Affichage du score dans le jeu

Un système a été ajouté pour afficher le score du joueur en temps réel pendant l'exécution du jeu. Le score est calculé en fonction de l'énergie du joueur, du nombre de collisions et du nombre de murs restants, et il est mis à jour à chaque collision. 

Le score est affiché à l'écran grâce à un objet **UI Text**. Ce texte est lié à un script `ScoreDisplay.cs`, qui récupère le score via le `ScoreManager` et l'affiche à chaque rafraîchissement de la scène dans le jeu. Le score est mis à jour en continu pendant le jeu, et il est visible par le joueur tout au long de l'expérience de jeu.

### Fonctionnement du calcul du score
Le score est calculé avec la formule suivante : Score = (Niveau d'énergie - Nombre de collisions) + Nombre de murs restants
Le score est affiché à chaque rafraîchissement du jeu pour donner un retour constant au joueur.
