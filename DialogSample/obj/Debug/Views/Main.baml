   M S B A M L   `   `   `  ����G  CDialogSample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:DialogSample.ViewsDialogSample.Views  5   	       DialogSample.Views.Main   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:DialogSample.Views     5   	     � Title$
  Main��5   	   $	��450��6   $	��800��6#    � 	Resources 5
         
CellCenter �� 
TargetType*  $System.Windows.Controls.DataGridCell �� Property �� Value �� 
TargetType  HeaderCenter=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%|  &	        &	 �     �� 5   
   "  5   	   .�5      ��  � �� 5      �� 5      "  6&   .R�5      � #��z��6   .+�5      �� $��Center=�6/   $��Center=�6J   5      5      5      5      �� 5   
   "  6%   .�5      ��  � ��$ 40��6'   �� 5       � ��$ Center=�62   �� 5       � ��$ Center=�6<   5      5      .��5      �  � RowDefinitions 5   
   �� 5       $
��auto �6   �� 5!      .+�5$   
   � $
��0 10q�6   .+�5%      �� $��按名称搜索：��6   $��Center=�6&   $��10 0 0 0q�6A   �� 5&      -   5         ��Name$ textBox1��5&      $	��200��6(   $��Center=�64   $��5q�6O   �� 5'      $��查询��6   $
��10 0q�6"   $
��20 5q�60   ��6?   �� *SearchCommand+��6a   ��  �� ElementName$ textBox1��	 �� Path$
	 Text��� 5(      $��添加��6   $
��10 0q�6"   $
��20 5q�60   $��UserAdd��6^   ��6?   �� *
AddCommand+6^   5)      &   System.Windows.Controls.DataGrid  5+   
   $��1��6   
   AutoGenerateColumns
 .     CanUserSortColumns .     CanUserAddRows .     CanUserDeleteRows .     	CellStyle# [  6�      ColumnHeaderStyle# [ 6�      	RowHeight$ 40Q�6  ��6�   �� *
UserList+   Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn   Header$ 编号��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *Id+  5.      $ 	用户名��6%   $ 70 62    6=   �� *	LoginName+  5/      $ 密码��6%   $ 70 61    6<   �� *
Password+  50      $ 头像��6%   $ 70 61    6<   �� *Logo+  51      $ 	手机号��6%   $ 90 62    6=   �� *Phone+  52      $ 创建时间��6%   $	 140 63    6?   �� *
CreateTime+ �� StringFormat$ yyyy-MM-dd HH:mm:ss��  53      $ 修改时间��6%   $	 140 63    6?   �� *
UpdateTime+$ yyyy-MM-dd HH:mm:ss��4  .System.Windows.Controls.DataGridTemplateColumn  54      $ 操作��6)   $ * 65      CellTemplate 55      �� 56      .R�57      � .+�58   "   �� $��编辑��6)   $
��10 0q�66   $
��20 5q�6D   ��6S   �� *DataContext.EditCommand+ �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType$ DataGridL���6�   �� *Id+59      5:      5<      5>      5?      5@      