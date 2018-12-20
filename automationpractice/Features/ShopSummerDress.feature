Feature: Shop Summer Dress

@PaviTest
Scenario: Shop Women Summer Dress
 Given Launch Shopping Portal
 Then Navigate To Women Summer Dress
 Then Pick a Dress And Choose Size and Qunatity
 | Qunatity | Size  |
 | 2        | M |
 Then Add To Cart And Proceed Checkout
# Then Create Account
