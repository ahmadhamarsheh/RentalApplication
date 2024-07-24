# Rental Application Project

The Rental Application is a console-based C# application that allows users to rent various types of properties such as apartments, separate houses, and shops. Each property comes with essential attributes including address, name, and size, along with other necessary characteristics.

## Key Features

- **Property Management**: Define and manage different types of properties (apartments, houses, shops) with specific attributes.
- **Customer Management**: Allow customers to rent multiple properties simultaneously and manage their rental portfolio.
- **Contract Management**: Generate detailed contracts between customers and property owners, including rental period, price, and other relevant information.
- **Payment Processing**: Support for multiple payment methods such as PayPal, Visa, and MasterCard, with simulated payment processing via console output.
- **Object-Oriented Design**: Implementation of key OOP principles including:
  - **Inheritance**: Property types (e.g., apartments, houses, shops) inherit from a base `Building` class.
  - **Abstraction**: Abstract classes and interfaces to define common behaviors and attributes.
  - **Polymorphism**: Different payment methods implementing a common interface for payment processing.
  - **Aggregation**: Customers aggregate rented buildings in their rental portfolio.
  - **Composition**: Contracts composed of customer and building details along with rental terms.
