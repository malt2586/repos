   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	       GUI.NewAccountWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	     � Title$  New Account��5   	   $	��200��6   $	��220��6*   .��5	      � $��10q�6    � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ lblID��5      $	��ID:��6   $��0��6-   $��Right=�6:   $��Center=�6]   �� 5   
   -   5        $ lblName��5      $��Name:��6!   $��1��61   $��Right=�6>   $��Center=�6a   �� 5   
   -   5        $ 
lblBalance��5      $��Balance:��6$   $��2��67   $��Right=�6D   $��Center=�6g   �� 5   
   -   5         ��Name$ tbxID��5       �� TextWrapping$
 Wrap=�6!   $��Identity��65   $��1��6E   $��Center=�6U   $��0��6w   $	��0,3q�6�   �� 5   
   -   5        $ tbxName��5      $
 Wrap=�6#   $��Unknown��67   $��1��6F   $��Center=�6V   $��1��6x   $	��0,3q�6�   �� 5   
   -   5        $ 
tbxBalance��5      $
 Wrap=�6&   $��50000��6:   $��1��6G   $��Center=�6W   $��2��6y   $	��0,3q�6�   �� 5   
   -   5         ��Name$ btnAddAccount��5      $��Add Account��6(   $��4��6>   $
��Left=�6K   $��2��6f   6z   5      5      