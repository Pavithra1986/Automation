Feature: Shop Summer Dress

@PaviTest
Scenario: Shop Women Summer Dress
 Given Launch Shopping Portal
 Then Navigate To Women Summer Dress
 Then Pick a Dress And Choose Size and Quantity
 | Quantity | Size  |
 | 2        | M |
 Then Add To Cart And Proceed Checkout
 Then Create Account
 | Email         | Title | Firstname | LastName | Password | Address                  | City         | State        | PostalCode | MobilePhone             | AddressReference     |
 | 1Pavithra@gmail.com | Mrs   |Pavithra   |Jai       |pavi.hari |   13D Watson Avenue      |     Auckland |  Indiana     | 12345      |   4534567891011          |       Pavi           |
 Then Name and Address Verification
 Then Continue With Shipping
 Then Payment And Submit
 Then Close The Browser

