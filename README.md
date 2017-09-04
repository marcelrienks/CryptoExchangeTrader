# Logic Flow
0. Buy BTC manually on the Exchange to be used as _Seed_
1. Get Coins
2. Get Prices for Coins
3. Get My Trades
4. Check for _UnExecuted orders_
    * If _UnExecuted orders_ exist  
    TODO: Think of logic for existing orders
    * Else If no _UnExecuted orders_ orders exist  
      Check last trade
        * If last trade was a buy  
        Compare last Buy price to price now
          * If _current price_ is higher than _last buy price_ + **_positive distance_**  
          Create _trailing stop_ at **_positive distance_**
          * Else If _current pricew_ is lower than _last buy price_ - **_negative distance_**  
          Create _stop_ order at _current price_
        * Else If last trade was a Sell  
        TODO: Think of logic for new Buy