#Buber Dinner API

- [Buber Dinner API](#buber-dinner-api)
    - [Auth](#auth)
        - [Register](#register)
            - [Register Request](#register-request)
            - [Register Response](#register-response)
        - [Login](#login)
            - [Login Request](#login-request)
            - [Login Response](#login-response)

## Auth

#### Register

```
POST {{host}}/auth/register
```

#### Register Request
```json
{
    "firstName": "Amichai",
    "lastName": "Mantinband",
    "email": "amichai@mantiband.com",
    "password": "Amiko1232!"
}
```

#### Register Response

```
200 OK
```

```
{
    "id": "d89c2d9a-eb3e-4075-95ff-b920b55aa104"
    "firstName": "amichai",
    "lastName": "Mantiband",
    "email": "amichai@matinband.com",
    "token": "eyJhb..z9dqcnXoY"
}
```

### Login

```
POST {{host}}/auth/login
```

#### Login Request
```json
{
    "email": "amichai@mantiband.com",
    "password": "Amiko1232!"
}
```

#### Login Response

```
200 OK
```

```
{
    "id": "d89c2d9a-eb3e-4075-95ff-b920b55aa104"
    "firstName": "amichai",
    "lastName": "Mantiband",
    "email": "amichai@matinband.com",
    "token": "eyJhb..z9dqcnXoY"
}
```