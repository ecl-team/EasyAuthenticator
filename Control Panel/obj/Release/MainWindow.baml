   M S B A M L   `   `   `  ���� H  DControl Panel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Control_PanelControl_Panel      Control_Panel.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:Control_Panel     -     �Name$  windowE�� � Title$ 
MainWindow��$	��450��$	��450��$	��800��$	��800�� � WindowStyle$
 None=� � AllowsTransparency .  � 
ResizeMode$ CanResizeWithGrip=�.���  � ColumnDefinitions �� $	��175 ��� .+��� -    ��Name$ titleBarRect�����	#FFE6E6E6$��25�����	#FFE4E4E4$	��Top=�$��2���� -    ��Name$ exitBtn��$��X��$	��Top=�$��25��$��Center=�$��Center=����	#FFE6E6E6���	#FFE6E6E6$��1��$��Right=�$��25���� -   $ minBtn��$	��___��$��0,0,25,0q�$	��Top=�$��25��$��Center=�$��Center=����	#FFE6E6E6���	#FFE6E6E6$��1��$��Right=�$��25���� -    ��Name$ TitleL��$��EasyAuthentication��$
��Left=�$��0,-1,0,0q�$	��Top=��� 
�������$��0��$��51��$��0,25,0,0q����	#7F000000$	��Top=��� 
�������$��0��$��55��$��0,77,0,0q����	#7F000000$	��Top=��� 
�������$��0��$��51��$��	0,132,0,0q����	#7F000000$	��Top=��� -   $ 
generalBtn��$��0q�$��General��$	��Top=�$��51�����	#00000000���	#00707070���	#FF292929$��36(�$��0,25,0,0q����� 	 �� 
TargetType"	 ��.��� 
 �� Property
 � �� �� Value
 � � ��� 
 � �� ��  �� 
TargetType" ��.R��� #��z��._��� $��Center=�$��Center=� �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ��� 
 � ��
 ������ -   $ setupBtn��$��0q�$��Setup��$	��Top=�$��57�����	#00000000���	#00707070���	#FF292929$��36(�$��0,76,0,0q����� "	 ��.��� 
 � ��
 � � ��� 
 � �� �� " ��.R��� #��z��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver . . ��� 
 � ��
 ������ -   $ otherBtn��$��0q�$��Other��$	��Top=�$��51�����	#00000000���	#00707070���	#FF292929$��36(�$��	0,127,0,0q����� "	 ��.��� 
 � ��
 � � ��� 
 � �� �� " ��.R��� #��z��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver . . ��� 
 � ��
 ����� -	    �Name$ generalGrid��$
��Left=�$	��425��$��0,25,0,0q�$	��Top=�$	��625��$y�Hidden=�$��1��� -
   $ 	setupGrid��$��0,25,0,0q�$y�Visible=�$��1��.+��� -    ��Name$ qrView��$	��200��$	��Top=�$��EmptyQRCode.png��$��Right=�$	��200���� -   $ revealQR��$��Reveal��$��0q�$��Right=�$��0,200,100,0q�$	��Top=�$	��100���� -   $ RegenerateQR��$��
Regenerate��$��0q�$��	0,200,0,0q�$	��Top=�$��Right=�$	��100��� -   $ settingsGrid��$
��Left=�$	��425��$��0,25,0,0q�$	��Top=�$	��625��$y�Hidden=�$��1���� ���	#3F000000$
��Left=�$��1��$��
10,132,0,0q����	#7F000000$	��Top=�$	��160���� ���	#3F000000$
��Left=�$��1��$��	10,76,0,0q����	#7F000000$	��Top=�$	��160��