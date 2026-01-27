# 🏆 BALDE X : BATTLE ROYALE (ULTIMATE EDITION)

<div align="center">

<div style="width: 300px; height: 450px; position: relative; perspective: 1000px;">
  <div style="position: absolute; width: 100%; height: 100%; border-radius: 50%; box-shadow: 0 0 50px #ffae00; animation: pulse 2s infinite;"></div>
  
  <svg viewBox="0 0 200 300" style="width: 100%; height: 100%; transform-style: preserve-3d;">
    <path d="M70,80 L130,80 L140,180 L60,180 Z" fill="#222" stroke="#444" stroke-width="2" />
    <path d="M80,90 L120,90 L125,150 L75,150 Z" fill="#333" /> <g style="animation: fist-pump 1.5s infinite ease-in-out;">
      <path d="M140,110 L170,60 L180,40" stroke="#d4a373" stroke-width="15" stroke-linecap="round" />
      <circle cx="180" cy="40" r="10" fill="#d4a373" /> </g>

    <circle cx="100" cy="50" r="25" fill="#d4a373" />
    <path d="M75,35 Q100,20 125,35 L125,55 L75,55 Z" fill="#1a1a1a" /> <rect x="60" y="100" width="10" height="80" transform="rotate(-45 60 100)" fill="#111" />
  </svg>
</div>

![License](https://img.shields.io/badge/Version-1.0.0_STABLE-gold?style=for-the-badge)
![Platform](https://img.shields.io/badge/Platform-Android_%7C_Web-orange?style=for-the-badge)

</div>

## 🛠 Architecture Technique (Logic Only)
Le projet utilise une architecture **découplée** pour simuler un backend sans serveur :
- **Core Engine:** Gestion des collisions et de la physique 3D via `Three.js`.
- **State Machine:** Gestion du passage de l'ouverture au lobby, puis au match.
- **Data Persistence:** Sauvegarde des niveaux (Bronze -> Diamant) via `localStorage`.

## 🎮 Systèmes Implémentés
| Système | Status | Description |
| :--- | :--- | :--- |
| **Luck Royale** | ✅ OK | Algorithme de probabilité pour les skins. |
| **Zone Safe** | ✅ OK | Calcul mathématique du cercle de réduction. |
| **Véhicules** | ✅ OK | Physique de conduite (Accélération/Frein). |
| **Armes** | ✅ OK | Système de recul et dispersion des balles. |

<style>
@keyframes pulse { 0% { opacity: 0.5; } 50% { opacity: 1; } 100% { opacity: 0.5; } }
@keyframes fist-pump { 0%, 100% { transform: translateY(0) rotate(0deg); } 50% { transform: translateY(-10px) rotate(5deg); } }
</style>
