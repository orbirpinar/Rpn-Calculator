# RPN CALCULATOR

### What Is It?

In reverse Polish notation, the [operators](https://en.wikipedia.org/wiki/Operation_(mathematics)) follow their [operands](https://en.wikipedia.org/wiki/Operands); for instance, to add 3 and 4 together, one would write 3 4 + rather than 3 + 4. If there are multiple operations, operators are given immediately after their final operands (often an operator takes two operands, in which case the operator is written after the second operand); so the expression written 3 − 4 + 5 in conventional notation would be written 3 4 − 5 + in reverse Polish notation: 4 is first subtracted from 3, then 5 is added to it. An advantage of reverse Polish notation is that it removes the need for parentheses that are required by [infix notation](https://en.wikipedia.org/wiki/Infix_notation). While 3 − 4 × 5 can also be written 3 − (4 × 5), that means something quite different from (3 − 4) × 5. In reverse Polish notation, the former could be written 3 4 5 × −, which unambiguously means 3 (4 5 ×) − which reduces to 3 20 − (which can further be reduced to -17); the latter could be written 3 4 − 5 × (or 5 3 4 − ×, if keeping similar formatting), which unambiguously means (3 4 −) 5 ×.

### How To Work?

- Run Application

```bash
dotnet run
```

- Open the postman or something similar 

  __endpoint__: /api/v1/calculate

  __method__: POST

  __request body__: 

  ```json
  {
      "expression": "3 4 +"
  }
  ```

  __example response__:

  ```json
  {
      "result": 7
  }
  ```

  __example curl__

  ```bash
  curl --location --request POST 'http://localhost:5176/api/v1/calculate' \
  --header 'Content-Type: application/json' \
  --data-raw '{
      "expression": "3 4 +"
  }'
  ```

  
