   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	       GUI.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	     � Title$  Bank Accounts��5   	   $	��350��6   $	��525��6,   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      .+�5   
   �� -   5         ��Name$ btnNewAccount��5      $��New Account��6(   $��
10,10,10,0q�6>   $	��5,1q�6R   $��1��6`   6m   �� 5   
   -   5        $ 
btnDeposit��5      $��Deposit��6%   $��
10,10,10,0q�67   $��2��6K   $	��5,1q�6X   6f   �� 5   
   -   5        $ btnWithdraw��5      $��Withdraw��6&   $��
10,10,10,0q�69   $��3��6M   $	��5,1q�6Z   6h   �� 5   
   -   5         ��Name$ lblAccounts��5      $��Accounts��6%   $��1��68   $
��Left=�6H   $��Bottom=�6c   �� 5   
   -   5         ��Name$ lbxAccounts��5      $��1��6'   $��	0,0,10,10q�67   $��4��6J   $��1��6[   5      5      