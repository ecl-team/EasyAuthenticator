   M S B A M L   `   `   `  ����E  ALockscreen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Lockscreen
Lockscreen  5   	       Lockscreen.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Lockscreen     5   	   J FWpfAnimatedGif, Version=1.4.17.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  5	   	   -   5          �Name$  
WindowMain��5   	    � Title$ 
MainWindow��5
   	   $	��350��6   $	��525��6)    � WindowStyle$
 None=�65    � 
ResizeMode$ NoResize=�6H    � WindowStartupLocation$ CenterScreen=�6^    � WindowState$ 	Maximized=�6�   ���	#33000000 � AllowsTransparency . .��5      �  � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $��20 �6   �� 5      $
��168* �6   �� 5      $	��25* �6   �� 5      $
��127* �6    � ColumnDefinitions 5   
   �� 5      $��10 �6   �� 5      $��20 �6   �� 5      $
��129* �6   �� 5      $
��205* �6   �� 5      $
��131* �6   �� 5      $��20 �6   �� 5      $��10 �6   .+�5   
   �� -   5        	 ��Name$	 gifBackground��5      "  WpfAnimatedGif.ImageBehavior
   AnimatedSource$
 
Locked.png��6'   $��7��6U   $��5��6i   �� 5   
   -   5         ��Name$ ExitBtn��5      $��X��6"   $��1��6D   $��1��6Q   $y�Hidden=�6a   �� 5   
   -   5        $ 	UnlockBtn��5      $��U��6$   $��5��6E   $��1��6U   $y�Hidden=�6b   � 5    
   $��6��6   $��1��6#   $��1��63   $��4��6@    5!      �� 5"      $
��205* �6    �� 5#      $	��30* �6    �� 5$      $
��122* �6     5&      �� 5'      $
��153* �6#   �� 5(      $
��102* �6#   �� 5)      $
��102* �6#   �� 5*      $
��158* �6#   .+�5,      �� -   5         ��Name$ codeInputField��5,       �� TextWrapping$
 Wrap=�6.   $��0q�6B   $�� ��6V   $��1��6^   $��1��6n   
������ ���	#00ABADB3 �� SelectionBrush �	#00000000$��Center=�6�   $��Center=�6�   $��60(�6  $��2��6@  � 5-      -   5         �Name$ leftBar��5-      $��0q�6+   $��10��6?   $��1��6K   $��Bottom=�6X   ���	#0000A2FF���	#00BCBCBC���	#FF00C5FF J� RenderTransformOrigin$ 0.5,0.5&�6�   $��1��6�   $��0,0,-1,0q�6�   $��1��6�    � Maximum$ 8Q�6  z�5.      V� 5/      .~�50      �� �� 51      �� 52       �� Angle$	 180Q�6*   T� 53      54      56      � 57      -   5        $ rightBar��57      $��0q�6,   $��2��6@   $��10��6P   $��1��6\   $��Bottom=�6i   ���	#FF00C5FF���	#00E6E6E6���	#00BCBCBC$ 0.5,0.5&�6�   $��-1,0,0,0q�6�   $ 8Q�6�   z�58      V� 59      .~�5:      �� �� 5;      �� 5<      $ 0Q�6*   T� 5=      5>      5@      �� 5A      -   5         ��Name$ 	timeLabel��5A      $�� ��6'   $��1��62   $��1��6B   $��2��6O   $��Center=�6c   $��Center=�6�   $��48(�6�   
�������$y�Hidden=�6�   5B      5C      5D      