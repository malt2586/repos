   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	       GUI.DepositWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	     � Title$  Deposit��5   	   $	��240��6   $	��280��6&   .��5	      � $��10q�6    � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ 	lblIDText��5      $	��ID:��6#   $��Right=�61   $��Center=�6T   $��0��6v   �� 5   
   -   5        $ lblNameText��5      $��Name:��6%   $��Right=�65   $��Center=�6X   $��1��6z   �� 5   
   -   5        $ lblWithdrawal��5      $��Deposit:��6'   $��Right=�6:   $��Center=�6]   $��4��6   �� 5   
   -   5        $ lblCurBalanceText��5      $��Current Balance:��6+   $��Right=�6F   $��Center=�6i   $��2��6�   �� 5   
   -   5        $ lblNewBalanceText��5      $��New Balance:��6+   $��Right=�6B   $��Center=�6e   $��3��6�   �� 5   
   -   5        $ lblID��5      $��ID��6   $��Center=�6,   $��0��6N   $��1��6[   �� 5   
   -   5        $ lblName��5      $
��Name��6!   $��Center=�60   $��1��6R   $��1��6_   �� 5   
   -   5        $ lblCurBalance��5      $��Current Balance��6'   $��Center=�6A   $��2��6c   $��1��6p   �� 5    
   -	   5        $ lblNewBalance��5       $��New Balance��6'   $��Center=�6=   $��3��6_   $��1��6l   �� 5!   
   -
   5         ��Name$ 
tbxDeposit��5!       �� TextWrapping$
 Wrap=�6&   $��1��6:   $��4��6J   $��Center=�6W   $	��0,3q�6y   $��Deposit��6�   �� 5#   
   -   5         ��Name$ 
btnDeposit��5#      $��Deposit��6%   $��2��67   $
��Left=�6K   $��6��6f   $��3��6s   $
��10,1q�6�   6�   5%      5&      