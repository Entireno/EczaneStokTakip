   M S B A M L   `   `   `  ����C  ?IlacStok, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:IlacStok.usercontrollerIlacStok.usercontroller  5      )    #IlacStok.usercontroller.satis_arsiv   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:IlacStok.usercontroller     5      -   5        .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5           Name$  satis��5
        HeadersVisibility$ Column=�6      AutoGenerateColumns .  $
��Left=�6J   $��0,40,0,0q�6{      	RowHeight$ 30Q�6�      CanUserAddRows .     CanUserResizeColumns .     CanUserDeleteRows .     CanUserSortColumns .    CanUserResizeRows .  
���iii�	   
IsReadOnly	 . ��6e   Z� ��6-  �� ��6E  Z� 
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$ Tarih��6V      MinWidth$	 104Q�6e   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ tarih�   ElementStyle 5      �� 5       �� 
TargetType" ��6    .�5      ��  �� Property � �� �� Value$
 Left=�6D   6S   �� 5       � ��$ Center=�6B   6S   �� 5       �@��Padding$ 5q�68   6D   �� 5       � ��
 �����6K   5         	CellStyle 5      �� 5      *  $System.Windows.Controls.DataGridCell"  6    .�5      ��  � �� �#e261af6M   5      5        5       . $ İlaç��6U   $	 104Q�6c    6%   �� $
 ilac� 5      �� 5      " ��6    .�5      ��  � ��$
 Left=�6D   6S   �� 5       � ��$ Center=�6B   6S   �� 5        �@��Padding$ 5q�68   6D   �� 5!       � ��
 �����6K   5"       5$      �� 5%      "  6    .�5&      ��  � �� �#e261af6M   5'      5)        5*       . $
 Adet��6W   $	 104Q�6e    6%   �� $ miktar� 5+      �� 5,      " ��6    .�5-      ��  � ��$
 Left=�6D   6S   �� 5.       � ��$ Center=�6B   6S   �� 5/       �@��Padding$ 5q�68   6D   �� 50       � ��
 �����6K   51       53      �� 54      "  6    .�55      ��  � �� �#e261af6M   56      58        59       . $ Toplam Fiyat��6W   $	 104Q�6m    6%   �� $ toplam� 5:      �� 5;      " ��6    .�5<      ��  � ��$
 Left=�6D   6S   �� 5=       � ��$ Center=�6B   6S   �� 5>       �@��Padding$ 5q�68   6D   �� 5?       � ��
 �����6K   5@       5B      �� 5C      "  6    .�5D      ��  � �� �#e261af6M   5E      5G        5H       . $ TC��6S   $	 104Q�6_    6%   �� $ tc� 5I      �� 5J      " ��6    .�5K      ��  � ��$
 Left=�6D   6S   �� 5L       � ��$ Center=�6B   6S   �� 5M       �@��Padding$ 5q�68   6D   �� 5N       � ��
 �����6K   5O       5Q      �� 5R      "  6    .�5S      ��  � �� �#e261af6M   5T      5V      5X      5Y      5Z      