This highlights an issue with the official bitcoin client.

- Alice is a regular windows user surfing the web and somehow manages to download an app which has the line in Form.cs
- When she runs this program, it alters her bitcoin client settings to have a transaction fee of 0.00000009 BTC. This could be anything. Let's say someone chose to make it 50 BTC.
- Alice has 51 BTC in her wallet.
- Alice opens bitcoin and sends 0.01 BTC to her friend.
- The alert message shows asks her to confirm the transaction of 0.01 BTC
- She clicks OK.
- She finds that her balance is now 0.99 BTC and doesn't understand why.

AVG virus scanner says that this executable is not a virus.

This can cause arbitrary loss of funds and it wouldn't take much to make it work in a 'smarter' way to cause maximum loss.

It causes no benefit to the attacker, but potentially enormous loss to the victim.

I have only produced this attack on Windows, and am not sure if the same vector can be exploited on other operating systems.

This is compelling evidence that the UI should present the fee to the user at every transaction, and/or that settings should be carefully controlled.

See https://bitcointalk.org/index.php?topic=102606.0