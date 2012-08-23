This highlights an issue with the official bitcoin client.

- Alice is a regular windows user and manages to download a program which contains the attack.
- When she runs this program, it (unknown to her) alters her bitcoin client settings to have a transaction fee of 50 BTC.
- Alice has 51 BTC in her wallet.
- Alice opens bitcoin and sends 0.01 BTC to her friend.
- The alert message asks her to confirm the transaction of 0.01 BTC, but does not say what the transaction fee is.
- She clicks OK.
- She finds that her balance is now 0.99 BTC and doesn't understand why.

The attached executable and source changes the fee to a non-malicious value of 0.00000009 BTC.

AVG virus scanner says that this executable is not a virus.

This attack can cause arbitrary loss of funds.

It causes no benefit to the attacker, but potentially enormous loss to the victim.

I have only produced this attack on Windows, and am not sure if the same vector can be exploited on other operating systems.

This is compelling evidence that the UI should present the fee to the user at every transaction, and/or that settings should be carefully controlled.

See https://bitcointalk.org/index.php?topic=102606.0