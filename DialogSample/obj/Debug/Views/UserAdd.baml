   M S B A M L   `   `   `  ����G  CDialogSample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:DialogSample.ViewsDialogSample.Views  5           DialogSample.Views.UserAdd   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:DialogSample.Views     5      T PPrism.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59[ WPrism.DryIoc.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5      ���#ffffff$��10q�5   4   #  Prism.Services.Dialogs.Dialog    WindowStartupLocation$  CenterOwner=�5	         WindowStyle 5      �� 5   
    �� 
TargetType" �6   .�5      ��  �� Property �@�WindowStyle �� Value$
 None=�6,   �� 5       � ��$	 400��6&   �� 5       � ��$	 300��6'   �� 5       �@�SizeToContent$ Manual=�6.   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6   .+�5   
   �� $��14(�6+   $
��Bold"�69   $��10q�6K   ��6   �� *Title+6K   � 5   
   $��1��6   $��Center=�6!   $��Center=�6<    � Orientation$ Vertical=�6Y   .+�5      � $
��0 10q�6   .+�5      �� $��用户名：��6   $��Center=�6(   �� 5      $	��100��6   $��5q�6K   ��6&   �� *UserModel.LoginName+6K   5       � 5!      $
��0 10q�6   .+�5"      �� $��密　码：��6   $��Center=�6/   �� 5#      $	��100��6   $��5q�6J   ��6&   �� *UserModel.Password+6J   5$      � 5%      $
��0 10q�6   .+�5&      �� $��头　像：��6   $��Center=�6/   �� 5'      $	��100��6   $��5q�6F   ��6&   �� *UserModel.Logo+6F   5(      � 5)      $
��0 10q�6   .+�5*      �� $��手　机：��6   $��Center=�6/   �� 5+      $	��100��6   $��5q�6G   ��6&   �� *UserModel.Phone+6G   5,      5-      � 5/   
   $��2��6   $��Right=�6!   .+�50      �� $��取消��6   $
��10 0q�6"   $
��20 5q�60   ��6?   �� *CancelCommand+�� 51      $��确定��6   $
��10 0q�6"   $
��20 5q�60   ��6?   �� *SaveCommand+52      53      54      