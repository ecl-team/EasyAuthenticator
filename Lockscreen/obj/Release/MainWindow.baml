   M S B A M L   `   `   `  ���� E  ALockscreen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Lockscreen
Lockscreen      Lockscreen.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:Lockscreen     J FWpfAnimatedGif, Version=1.4.17.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  -     �Name$  
WindowMain�� � Topmost .  � Title$ 
MainWindow��$	��350��$	��525�� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowState$ 	Maximized=����	#33000000 � AllowsTransparency . .���  � RowDefinitions �� $��10 ��� $��20 ��� $
��168* ��� $	��25* ��� $
��127* �	 � ColumnDefinitions	 �� $��10 ��� $��20 ��� $
��129* ��� $
��205* ��� $
��131* ��� $��20 ��� $��10 �.+��� -   
 ��Name$
 gifBackground��"  WpfAnimatedGif.ImageBehavior   AnimatedSource$ 
Locked.png��$��7��$��5���� -    ��Name$ ExitBtn��$��X��$��1��$��1��$y�Hidden=��� -   $ 	UnlockBtn��$��U��$��5��$��1��$y�Hidden=�� $��6��$��1��$��1��$��4�� �� $
��205* ��� $	��30* ��� $
��122* �	 �� $
��153* ��� $
��102* ��� $
��102* ��� $
��158* �.+��� -    ��Name$ codeInputField�� �� TextWrapping$
 Wrap=�$��0q�$�� ��$��1��$��1��
������ ���	#00ABADB3 �� SelectionBrush �	#00000000$��Center=�$��Center=�$��60(�$��2��� -    �Name$ leftBar��$��0q�$��10��$��1��$��Bottom=����	#0000A2FF���	#00BCBCBC���	#FF00C5FF J� RenderTransformOrigin$ 0.5,0.5&�$��1��$��0,0,-1,0q�$��1�� � Maximum$ 8Q�z�V� .~��� �� ��  �� Angle$	 180Q�T� � -   $ rightBar��$��0q�$��2��$��10��$��1��$��Bottom=����	#FF00C5FF���	#00E6E6E6���	#00BCBCBC$ 0.5,0.5&�$��-1,0,0,0q�$ 8Q�z�V� .~��� �� �� $ 0Q�T� �� -    ��Name$ 	timeLabel��$�� ��$��1��$��1��$��2��$��Center=�$��Center=�$��48(�
�������$y�Hidden=�