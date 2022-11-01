## 实验要求

按参考资源要求，制作一个粒子系统

用代码控制使之在不同场景下效果不一样

## 实验步骤

创建一个平面plane，缩放x设为10，z设为10。

创建一个粒子系统Particle System，将位置y设为20

旋转Directional Light，使背景变暗

设置Shape：Box

设置Scale：（100，100，1）

设置Emission中的Rate over Time：100

设置Veclocity Over Lifetime：（-1，-1，-1）

设置Noise中的Separate Axes：（0.2，0.1，0.2）

设置Color over Lifetime，调节透明度使粒子淡出

## 代码控制

创建ParticleSystemBehaviourScript.cs脚本

在Update()方法中修改粒子的size使粒子的大小逐渐变小，修改maxParticles使粒子数量逐渐减小。

将该脚本挂载到Particle System上，即可实现雪逐渐减小的效果。

## 实验效果

创建新项目，替换Assets

效果图如Image.jpg

脚本如ParticleSystemBehaviourScript.cs



