   M S B A M L   `   `   `  ����D  @PPproduct, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:PPproduct	PPproduct  5   	       PPproduct.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:PPproduct     5   	     � Title$  Авторизация��5   	   $	��450��6   $	��800��6*    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   � $��1��6   $��1��6   $��2��6,   $��2��6@    5      �� 5      �� 5      �� 5       5      �� 5      $	��36* �6    �� 5      $	��34* �6    �� 5       $	��35* �6    .+�5"      �� $��
Логин��6   $��81��6$   $
��Left=�6/   $��Center=�6J   $��16(�6n   $��	51,40,0,2q�6|   �� 5#      $��Пароль��6   $��81��6%   $
��Left=�60   $��Center=�6K   $��16(�6o   $��
51,24,0,14q�6}   $��1��6�   �� 5$      -   5         ��Name$ LoginBox��5$      $
��Left=�6(   $��18(�6C   $��30��6Q    �� TextWrapping$
 Wrap=�6]   $	��Top=�6r   $	��130��6�   $��1��6�   $��0,40,0,0q�6�   6�   �� 5%      -   5        $ PassBox��5%      $
��Left=�6'   $��18(�6B   $��30��6P   $
 Wrap=�6\   $	��Top=�6q   $	��130��6�   $��1��6�   $��0,24,0,0q�6�   $��1��6�   �� 5&      -   5        $"��Авторизоваться��5&      $��20��6.   $��1��6<   $��Center=�6L   $��
20,49,18,0q�6i   $��2��6}   $	��Top=�6�   $��94��6�   
�������6�   5(      5+      5,      