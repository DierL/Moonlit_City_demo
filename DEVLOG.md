# 《月下幻行》Demo — Development Log

> **《月下幻行》Demo**（Moonlit City Demo）是一款正在开发中的 2D Roguelike 游戏 Demo。
> **Moonlit Demo** is a 2D Roguelike game prototype currently in development.

> 主角在由梦境具象化而成的「盲区」战斗，探索被他人遗忘的记忆，最终被凌白“救走”，离开盲区。
> The protagonist fights within the “Blind Zone,” a place where dreams take physical form, exploring memories forgotten by others before eventually being “rescued” by Ling Bai and escaping the Blind Zone.

---

## 2026-07

### 2026-07-15

**《月下幻行》demo版企划诞生了！**
**The concept for the Moonlit City Demo was born!**

---

### 2026-07-17

**WASD移动完成。**
**WASD movement completed.**

**一个青色方块在屏幕上动了起来。这是伊尔最初的生命形态。**
**A cyan square started moving across the screen. This was Ylir's very first form of life.**

---

### 2026-07-20

**完成了镜头跟随，并重新规划了战斗系统。现在已经有点肉鸽的味儿了。**
**Camera following was completed, and the combat system was redesigned. It was starting to feel a little Roguelike.**

---

### 2026-07-21

**完成鼠标坐标和左右键输入，后面的战斗需要用到。**
**Mouse position detection and left/right mouse input were completed. These will be needed for the combat system later on.**

---

### 2026-07-23

**完成了Hover的逻辑。现在鼠标晃到可交互物品上有白色描边。**
**Completed the Hover system. Interactable objects now display a white outline when the mouse moves over them.**

---

### 2026-07-24

**完成了鼠标的切换，鼠标移到怪物上会变成剑。现在战斗初具雏形。**
**Completed the cursor switching system. The cursor now changes into a sword when hovering over an enemy. The combat system is starting to take shape.**

---

### 2026-07-26

**完成了攻击的锁定。**
**Completed attack target locking.**

---

### 2026-07-28

**完成了子弹飞行。《月下幻行》的第一颗子弹诞生了！**
**Completed projectile movement. The very first bullet of Moonlit Demo was born!**

---

### 2026-07-30

**完成了子弹销毁。现在碰到怪物会销毁。最基本的游戏玩法已经诞生了！！**
**Completed projectile destruction. Bullets are now destroyed when they hit an enemy. The most basic gameplay loop has finally been born!!**

---

## 2026-08

### 2026-08-01

**完成了怪物血条和子弹伤害的逻辑。现在子弹可以打死怪物了。**
**Completed enemy health and projectile damage logic. Bullets can now actually kill enemies.**

---

### 2026-08-03

**完成了攻击范围内的索敌攻击！现在有有效的攻击范围了！**
**Completed target detection and attacks within the attack range! The player now has a proper attack range!**

---

### 2026-08-04

**完成了 攻击范围内外的鼠标图案切换。现在在攻击范围以内是剑，攻击范围以外是眼睛！**
**Completed cursor switching based on attack range. The cursor is now a sword inside the attack range and an eye outside of it!**

---

### 2026-08-05

**完成了普通攻击的子弹冷却。现在子弹有发射频率上限了，当玩家在子弹冷却期间试图发射时，子弹将无法发射。**
**Completed the basic attack projectile cooldown. Bullets now have a maximum firing rate. If the player attempts to attack while the projectile is still on cooldown, no new bullet will be fired.**

---

### 2026-08-06

**完成了R键持续攻击的基本功能。R键=自动攻击，可开关。功能仍待完善。**
**Completed the basic functionality of R-key continuous attacking. R = Auto Attack, which can be toggled on and off. The system still needs further improvements.**

---

### 2026-08-07

**添加了R键可以手动切换攻击目标的功能。修改了自动攻击开启时仍能手动攻击的bug。添加了R键自动寻找范围内最近目标持续攻击的功能。**
**Added the ability to manually switch attack targets with the R key. Fixed a bug that allowed manual attacks while Auto Attack was active. Added automatic targeting of the nearest enemy within range and continuous attacking while Auto Attack is enabled.**

---

### 2026-08-08

**添加了自动攻击开启时，目标死亡会自动寻找下一目标攻击的功能。**
**Added automatic target switching when the current target dies while Auto Attack is active.**

---

### 2026-08-09

**完成了持续攻击开启时，怪物远离攻击范围会取消锁定，简称拉脱。**
**Completed the “leash” system. When continuous attack is active, an enemy leaving the attack range will automatically break the player's lock-on.**

**拉脱后，范围内重新进入怪物时，需要再次按R键方可开启自动攻击。**
**After breaking the lock-on, enemies re-entering the attack range will not automatically restart the attack. The player must press R again to resume Auto Attack.**

**完成了攻击范围指示器的出现时机。**
**Completed the timing logic for displaying the attack range indicator.**

**R键功能已完成！**
**The R-key system is now complete!**

---

### 2026-08-10

**完成了基础空A（暂时不能根据角色朝向改变空A方向）。**
**Completed the basic “blind attack” (free-aim attack). The firing direction cannot yet change according to the character's facing direction.**

**以及左键在未点击到范围内怪物的情况下，会锁定最近的怪物攻击。**
**Also added automatic targeting of the nearest enemy when the player clicks the left mouse button without directly clicking on an enemy within attack range.**

**已将该项目上传至GitHub！**
**The project has now been uploaded to GitHub!**

---

### 2026-08-13

**增加了空A可以根据左右朝向改变攻击方向的功能。**
**Added the ability for free attack to change its attack direction based on the character's left or right orientation.**

---

### 2026-08-14

**修正了左键点击空白处时会切换已手动锁定的目标的问题。**
**Fixed an issue where left-clicking on a blank area would switch the manually locked target.**

---

### 2026-08-15

**重塑了子弹的飞行逻辑。**
**Redo the bullet trajectory.**

**基础的战斗系统已经完成！正好耗时一个月。接下来应该是跟怪物相关的新篇章了。**
**The basic combat system is complete! It took exactly one month. Next up should be a new chapter involving enemies.**

---

### 2026-08-19

**完成了怪物的警戒范围和警戒图标。**
**Completed the enemy's alert range and alert icon.**

**现在怪物可以检测到玩家了！**
**Enemies can now detect player!**

---

### 2026-08-23

**完成了怪物对玩家的追击和拉脱。**
**Completed the features of enemy chasing the player and stopping to move when the player leaves its attack range.**

**真正的战斗开始了！测试也变得逐渐有难度起来……**
**It looks like a real battle now! Meanwhile testing becomes more and more complicated...**

---

### 2026-08-24

**试图解决怪物追击过程中产生的bug，最后发现是攻击范围设计小了。**
**Trying to fix a bug that occurred during the enemy chase, and eventually found out that the attack range was designed to be too small.**

---

### 2026-08-25

**加入了怪物的巡逻，并且设定了拉脱的逻辑。**
**Added the enemy's patrol and also the logic for pull-out.**

**添加了怪物状态的enum。**
**Added an enum for enemy state. Reorganized the code.**

---

### 2026-08-28

**加入了可以用鼠标拖动和缩放镜头的功能。**
**Added mouse-based camera controls, including camera panning and zooming.**

**在input system中加入了的action，对旧的代码也进行了重整，修复了期间出现的bug。**
**Added the necessary actions to the Input System, reorganized and cleaned up existing code, and fixed several bugs encountered during the process.**

---

### 2026-08-30

**重大进展！完成了怪物的基础AI！修复了期间产生的bug。**
**Great progress! Completed the basic Enemy AI! Fixed several bugs encountered during the process**

**第一个怪物的名字叫“补丁”，是一个近战怪物，被它碰到会造成伤害。**
**The first enemy is called "Patch," and it's a melee monster that will cause damage if player touches it.**

---

## 2026-09

### 2026-09-17

**两个星期之后的回归。**
**A Return After Two Weeks**

**完成了远程怪Shooter，会发射子弹攻击玩家。玩家可以通过走位来躲避。**
**Added the ranged enemy, Shooter! It can now fire projectiles at the player, while the player can dodge the attacks through movement.**

**怪物的开发暂时告一段落了！游戏的可玩性也在渐渐提升！接下来就会开发房间相关的机制了！**
**The enemy development phase is temporarily coming to an end! The game's playability is gradually taking shape, and the core gameplay is starting to feel more complete.**
**Next up: the Room System! I'll be moving on to developing room-related mechanics and building the foundation for the game's roguelike loop.**

### 2026-10-14

**凌晨两点。对于拖更真是太抱歉了，但在离开的日子里更新了一些IP相关的剧情和文案。一切都在渐渐变好！**

**近些时日断断续续完成了房间相关的设计。过程中尝试了贴地板，以失败告终。素材不合格。**

**不过这也让我为月下幻行的开发团队引入了新的成员！（见Contributor）luks牢尸一直以来负责素材的绘制，以后也会由她负责月下幻行美术素材的引入，而本人会继续玩法和功能方面的开发。**

**今天我完成了房间的基础逻辑：房间内怪物死亡后，房间的出口会解锁。现在，一个简单的房间完成了。有玩家，战斗和通关条件。**

**目前随着功能的完善，我们发现玩法/手感上存在着一些问题，会尽力在开发的过程中修复。**

**接下来要攻克的一大难关是房间的循环————作为肉鸽最核心的玩法，这是最需要钻研的部分。**

**During my absence, I managed to make some progress on the story and writing for the game's IP. Things are slowly getting better! Sorry for the long silence!**
**I've also been working on the room system on and off recently. I tried setting up the floor tiles, but unfortunately, it didn't work out. The assets weren't quite up to the task yet.**
**On the bright side, this also marks the arrival of a new member on the Moonlit City development team! (See Contributors.) luks has been creating the game's artwork and will continue to handle art asset creation and integration, while I'll focus on gameplay and feature development.**
**Today, I finished the basic room logic: the exits unlock once all enemies in a room have been defeated. A simple room is finally complete, with a player, combat, and a clear win condition.**
**As more features come together, we're also starting to notice some issues with gameplay and game feel. I'll do my best to address and improve them as development continues.**
**The next major challenge is the room progression loop. As one of the core gameplay systems in a roguelike, it'll take plenty of thought, experimentation, and refinement to get right.**