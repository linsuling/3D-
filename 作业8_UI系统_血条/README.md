## 作业要求
血条（Health Bar）的预制设计。具体要求如下

• 使用 IMGUI 和 UGUI 实现

• 使用 UGUI，血条是游戏对象的一个子元素，任何时候需要面对主摄像机

• 分析两种实现的优缺点

• 给出预制的使用方法

## 实验步骤

UGUI：

创建一个RawImage和Image，设置为合适的大小和位置，创建一个空物体挂载上脚本，RectTransform指定为RawImage，liftBarRect指定为Image。运行代码，在Game界面，按下"a"，则血条减少，按下"d"，则血条增加，颜色随之变化。

效果如下：

<img src="https://github.com/linsuling/3D_game_homework_file/blob/main/%E4%BD%9C%E4%B8%9A8_UI%E7%B3%BB%E7%BB%9F_%E8%A1%80%E6%9D%A1/Images/pic1.jpg" />

<img src="https://github.com/linsuling/3D_game_homework_file/blob/main/%E4%BD%9C%E4%B8%9A8_UI%E7%B3%BB%E7%BB%9F_%E8%A1%80%E6%9D%A1/Images/pic2.jpg" />

<img src="https://github.com/linsuling/3D_game_homework_file/blob/main/%E4%BD%9C%E4%B8%9A8_UI%E7%B3%BB%E7%BB%9F_%E8%A1%80%E6%9D%A1/Images/pic3.jpg" />

IMGUI：

主要是使用GUIStyle指定控件的实时颜色背景，在OnGUI()中每次根据变量的值渲染控件的长度。

导入红绿橙颜色的图片，创建一个空物体，挂载上脚本，将三种Texture指定为对应的颜色图片。运行代码，在Game界面，按下"+"按钮，则血条增加，按下"-"，则血条减少，颜色随之变化。

效果如下：

<img src="https://github.com/linsuling/3D_game_homework_file/blob/main/%E4%BD%9C%E4%B8%9A8_UI%E7%B3%BB%E7%BB%9F_%E8%A1%80%E6%9D%A1/Images/pic4.png" />

<img src="https://github.com/linsuling/3D_game_homework_file/blob/main/%E4%BD%9C%E4%B8%9A8_UI%E7%B3%BB%E7%BB%9F_%E8%A1%80%E6%9D%A1/Images/pic5.png" />

<img src="https://github.com/linsuling/3D_game_homework_file/blob/main/%E4%BD%9C%E4%B8%9A8_UI%E7%B3%BB%E7%BB%9F_%E8%A1%80%E6%9D%A1/Images/pic6.png" />

## 运行步骤

创建空项目，分别替换UGUI和IMGUI文件夹下的Assets文件夹即可。

HealthBarScript.cs是UGUI实现的脚本。

IMGUIScript.cs是IMGUI实现的脚本。
