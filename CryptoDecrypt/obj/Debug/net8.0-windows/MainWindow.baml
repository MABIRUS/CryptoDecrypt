   M S B A M L   `   `   `  ����H  DCryptoDecrypt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:CryptoDecryptCryptoDecrypt  5   	       CryptoDecrypt.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:CryptoDecrypt     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��400��6)   .��5
      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $��The source text:��6   $��15(�6,   $��5,20,0,0q�6:   �� 5   
   -   5         ��Name$ tbSource��5      �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   .+�5      �� $
��🠁��6   $��Center=�6"   $��60(�6=   �� 5      -   5         ��Name$ 
btnDecrypt��5      $��Decrypt��6)   ${�False��6T   �� 5      -   5         ��Name$ cbCipher��5      $	��120��6)   $��40��65   $��15(�6A   $��Center=�5      $��Center=�6;   5      �� 5      -   5        $ 
btnEncrypt��5      $��Encrypt��6)   ${�False��6T   �� 5      $
��🠃��6   $��Center=�6"   $��60(�6=   5      �� 5!   
   -   5        $ 	tbCrypted��5!      $��2��6%   �� 5"   
   $��2��6   $��Encrypted text:��6!   $��15(�68   $��5,20,0,0q�6F   5#      5$      