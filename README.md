<html>
<head>
<style>
body {
  font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
  background: linear-gradient(135deg, #0a1f44, #02182f);
  color: #ffffff;
  line-height: 1.6;
  padding: 20px;
}
h1, h2, h3 {
  color: #00d4ff;
  text-shadow: 1px 1px 5px #000000;
}
.section {
  border-radius: 15px;
  padding: 15px;
  margin-bottom: 20px;
  background: linear-gradient(145deg, #01121f, #022b44);
  box-shadow: 2px 2px 15px #00000088;
}
.code-block {
  background: #02182f;
  padding: 15px;
  border-radius: 10px;
  overflow-x: auto;
  font-family: monospace;
  color: #00ffdc;
}
table {
  width: 100%;
  border-collapse: collapse;
  margin-top: 10px;
}
th, td {
  border: 1px solid #00d4ff;
  padding: 8px;
  text-align: center;
}
th {
  background: #011f44;
}
</style>
</head>
<body>

<div class="section">
<h1>🎮 BALDE X — Battle Royale Ultra-Réaliste</h1>
<p>Bienvenue dans <strong>BALDE X</strong>, un jeu Battle Royale inspiré de Free Fire, avec des personnages 3D ultra-réalistes, animations fluides et gameplay immersif. Tout est codé localement pour l'instant, sans backend.</p>
</div>

<div class="section">
<h2>👤 Personnage 3D Principal</h2>
<p>Notre personnage principal :</p>
<ul>
<li>Ultra-réaliste avec textures détaillées</li>
<li>Animation : poing levé, légèrement relevé, en posture de victoire</li>
<li>Équipement : gilet tactique, armes modernes, vêtements stylés</li>
<li>Animations fluides avec Unity Animator ou équivalent</li>
<li>Logique intégrée localement : déplacement, tir, loot</li>
</ul>

<div class="code-block">
Character3D character = new Character3D();
character.Animation = "FistUp";
character.Equip("TacticalVest");
character.Equip("ModernRifle");
character.Clothes = "StylishBattleOutfit";
character.Position = new Vector3(0,0,0);
character.EnableLocalControls();
</div>
</div>

<div class="section">
<h2>🗺️ Map et Gameplay</h2>
<ul>
<li>Mode Solo / Duo / Squad (simulation locale)</li>
<li>Loot : armes, armures, soins</li>
<li>Zone qui rétrécit avec avertissements visuels</li>
<li>Mini-map dynamique</li>
<li>HUD clair avec santé, armure, ammo</li>
</ul>

<div class="code-block">
Map gameMap = new Map("IslandBattlefield");
gameMap.SpawnLoot();
gameMap.SetSafeZone(1000f);
gameMap.UpdateMiniMap();
</div>
</div>

<div class="section">
<h2>🛠️ Commandes et Contrôles</h2>
<table>
<tr><th>Action</th><th>Touche / Contrôle</th></tr>
<tr><td>Déplacer</td><td>W / A / S / D</td></tr>
<tr><td>Sauter</td><td>Space</td></tr>
<tr><td>Accroupir</td><td>Ctrl</td></tr>
<tr><td>Tirer</td><td>Left Mouse</td></tr>
<tr><td>Vise</td><td>Right Mouse</td></tr>
<tr><td>Inventaire</td><td>I</td></tr>
</table>
</div>

<div class="section">
<h2>🎨 UI / Couleurs</h2>
<p>Le style BALDE X utilise :</p>
<ul>
<li>Thème principal : Bleu néon / Dégradé marine</li>
<li>Menus stylés avec bordures arrondies et ombres douces</li>
<li>Animations de transition entre Lobby → Match → Résultats</li>
<li>Effets visuels sur armes, zones et HUD</li>
</ul>
</div>

<div class="section">
<h2>📦 Structure du projet GitHub</h2>
<pre class="code-block">
/BALDE-X
 ├── /Assets
 │    ├── /3DModels
 │    ├── /Animations
 │    ├── /Textures
 │    └── /Scripts
 ├── /Scenes
 │    ├── Splash.unity
 │    ├── Lobby.unity
 │    ├── Match.unity
 │    └── Result.unity
 ├── README.md
 └── ProjectSettings
</pre>
</div>

<div class="section">
<h2>🚀 Comment lancer BALDE X</h2>
<ol>
<li>Cloner le projet depuis GitHub</li>
<li>Ouvrir Unity 2024+</li>
<li>Importer les packages nécessaires</li>
<li>Lancer la scène <strong>Lobby.unity</strong></li>
<li>Tester les commandes et animations locales</li>
<li>Vérifier le HUD et personnage 3D animé</li>
</ol>
</div>

<div class="section">
<h2>🎯 Objectifs futurs</h2>
<ul>
<li>Ajout du multiplayer réel via Photon / Mirror</li>
<li>Intégration d’un backend (Supabase / Firebase)</li>
<li>Optimisation mobile Android</li>
<li>Déploiement sur GitHub Pages et Vercel pour previews</li>
<li>Animations supplémentaires et skins réalistes</li>
</ul>
</div>

<div class="section">
<h2>💡 Notes</h2>
<p>Tous les scripts sont codés localement pour l’instant.  
Les personnages et armes utilisent des classes modulaires avec ScriptableObjects pour une configuration facile et évolutive.  
README entièrement stylé avec couleurs, sections, tableaux et code interactif.</p>
</div>

</body>
</html>
