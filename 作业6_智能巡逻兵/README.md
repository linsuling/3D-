## 游戏设计要求

• 创建一个地图和若干巡逻兵(使用动画)；

• 每个巡逻兵走一个3~5个边的凸多边型，位置数据是相对地址。即每次
确定下一个目标位置，用自己当前位置为原点计算；

• 巡逻兵碰撞到障碍物，则会自动选下一个点为目标；

• 巡逻兵在设定范围内感知到玩家，会自动追击玩家；

• 失去玩家目标后，继续巡逻；

• 计分：玩家每次甩掉一个巡逻兵计一分，与巡逻兵碰撞游戏结束；


## 动画资源

在资源商店搜索，下载资源Mini Legion Footman PBR HP Polyart

<img src="https://github.com/linsuling/3D_game_homework_file/blob/main/%E4%BD%9C%E4%B8%9A6_%E6%99%BA%E8%83%BD%E5%B7%A1%E9%80%BB%E5%85%B5/Images/pic0.jpg" />

## 实验步骤

导入资源后，选择一个模型为巡逻兵patrol，一个模型为玩家player

设置预制体的属性，添加Rigidbody和Capsule Collider部件，在Hips中添加Box Collider为与巡逻兵互相感应的范围。

设置AnimatorController：patrol的状态一直为run；player的状态为前进时run，不前进时idle，碰撞到巡逻兵后death。

patrol动画控制器如下：

<img src="https://github.com/linsuling/3D_game_homework_file/blob/main/%E4%BD%9C%E4%B8%9A6_%E6%99%BA%E8%83%BD%E5%B7%A1%E9%80%BB%E5%85%B5/Images/pic1.jpg" />

player动画控制器如下：

<img src="https://github.com/linsuling/3D_game_homework_file/blob/main/%E4%BD%9C%E4%B8%9A6_%E6%99%BA%E8%83%BD%E5%B7%A1%E9%80%BB%E5%85%B5/Images/pic2.jpg" />

## 脚本

1.相机脚本CameraBehaviourScript.cs，控制相机跟在人物背后

2.巡逻兵脚本PatrolBehaviour.cs，控制巡逻兵走正方形巡逻，感应到玩家后追赶玩家，感应不到后给玩家加分。

3.玩家脚本PlayerBehaviourScript.cs，控制玩家行走，使用键盘读入wsad为前进后退左转右转。与巡逻兵碰撞则玩家死亡，游戏结束。与目的地碰撞则玩家成功，游戏结束。OnGui显示当前分数。

## 运行步骤

创建新项目，替换Assets文件即可。

## 效果

游戏进行时效果如下：

左下角为玩家，右上角的粉红方块为目的地，左上角显示当前分数，玩家需要控制人物不与巡逻兵相碰并到达目的地。

<img src="https://github.com/linsuling/3D_game_homework_file/blob/main/%E4%BD%9C%E4%B8%9A6_%E6%99%BA%E8%83%BD%E5%B7%A1%E9%80%BB%E5%85%B5/Images/Image.jpg" />
