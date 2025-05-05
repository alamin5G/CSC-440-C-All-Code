## Electronics Store Application Endpoints

This list outlines the defined web endpoints, their HTTP methods, purpose, and required authorization level.

---

**1. MainController (Public Access & Core)**

| Method | URL Pattern        | Action                                 | Description                                   | Authorization |
| :----- | :----------------- | :------------------------------------- | :-------------------------------------------- | :------------ |
| GET    | `/`              | home                                   | Displays the homepage (featured/new products) | Public        |
| GET    | `/search`        | searchProducts                         | Displays product search results (paginated)   | Public        |
| GET    | `/about`         | about                                  | Displays the About Us page                    | Public        |
| GET    | `/contact`       | contact                                | Displays the Contact Us page                  | Public        |
| GET    | `/login`         | *(Handled by Security/Custom)*       | Shows the login page                          | Public        |
| POST   | `/login`         | *(Handled by Security)*              | Processes login submission                    | Public        |
| GET    | `/register`      | *(Handled by Auth/User Controller)*  | Shows the registration page                   | Public        |
| POST   | `/register`      | *(Handled by Auth/User Controller)*  | Processes registration submission             | Public        |
| POST   | `/logout`        | *(Handled by Security)*              | Logs the user out                             | Authenticated |
| GET    | `/error/404`     | *(Handled by Error Controller/View)* | Displays the 404 Not Found page               | Public        |
| GET    | `/error/generic` | *(Handled by Error Controller/View)* | Displays a generic error page                 | Public        |

*(Note: Login/Register GET/POST might be in a dedicated AuthController or UserController depending on final implementation)*

---

**2. ProductController (Public Product Views)**

| Method | URL Pattern                         | Action                                 | Description                                     | Authorization |
| :----- | :---------------------------------- | :------------------------------------- | :---------------------------------------------- | :------------ |
| GET    | `/products`                       | listProducts                           | Displays product listing with filters/sort/page | Public        |
| GET    | `/products/{id}`                  | showProductDetails                     | Displays details for a single product           | Public        |
| GET    | `/products/brand/{brandId}`       | showProductsByBrand                    | Displays products filtered by brand             | Public        |
| GET    | `/products/category/{categoryId}` | showProductsByCategory                 | Displays products filtered by category          | Public        |
| GET    | `/search`                         | *(Likely handled by MainController)* | Displays search results                         | Public        |

---

**3. CartController (User Shopping Cart)**

| Method | URL Pattern                   | Action                 | Description                       | Authorization |
| :----- | :---------------------------- | :--------------------- | :-------------------------------- | :------------ |
| POST   | `/cart/add/{productId}`     | addToCart              | Adds a product to the user's cart | Authenticated |
| GET    | `/cart`                     | viewCart               | Displays the user's shopping cart | Authenticated |
| POST   | `/cart/update/{cartItemId}` | updateCartItemQuantity | Updates quantity of an item       | Authenticated |
| POST   | `/cart/remove/{cartItemId}` | removeCartItem         | Removes an item from the cart     | Authenticated |
| POST   | `/cart/clear`               | clearCart              | Removes all items from the cart   | Authenticated |

---

**4. CheckoutController (Multi-Step Checkout)**

| Method | URL Pattern                   | Action                          | Description                              | Authorization |
| :----- | :---------------------------- | :------------------------------ | :--------------------------------------- | :------------ |
| GET    | `/checkout/shipping`        | showShippingAddressSelection    | Displays shipping address selection step | Authenticated |
| POST   | `/checkout/shipping/select` | processShippingAddressSelection | Handles selected shipping address        | Authenticated |
| GET    | `/checkout/payment`         | showPaymentMethodSelection      | Displays payment method selection step   | Authenticated |
| POST   | `/checkout/payment/select`  | processPaymentMethodSelection   | Handles selected payment method          | Authenticated |
| GET    | `/checkout/review`          | showOrderReview                 | Displays the order review step           | Authenticated |
| POST   | `/checkout/place-order`     | placeOrder                      | Submits the order for processing         | Authenticated |
| GET    | `/checkout/cancel`          | cancelCheckout                  | Cancels checkout, clears session DTO     | Authenticated |

---

**5. OrderController (User Order Viewing)**

| Method | URL Pattern                         | Action                | Description                                 | Authorization |
| :----- | :---------------------------------- | :-------------------- | :------------------------------------------ | :------------ |
| GET    | `/order/confirmation/{orderId}`   | showOrderConfirmation | Displays confirmation after order placement | Authenticated |
| GET    | `/order/history`                  | showOrderHistory      | Displays user's paginated order history     | Authenticated |
| GET    | `/order/{orderId}`                | showOrderDetails      | Displays details of a specific past order   | Authenticated |
| POST   | `/order/submit-payment/{orderId}` | submitPaymentDetails  | Submits user payment details (e.g., TrxID)  | Authenticated |

---

**6. UserController (User Profile & Address Management)**

| Method | URL Pattern                                 | Action               | Description                             | Authorization |
| :----- | :------------------------------------------ | :------------------- | :-------------------------------------- | :------------ |
| GET    | `/user/profile`                           | userProfile          | Displays the user's profile information | Authenticated |
| GET    | `/user/edit-profile`                      | showEditProfileForm  | Shows the form to edit profile details  | Authenticated |
| POST   | `/user/update-profile`                    | processUpdateProfile | Handles profile update submission       | Authenticated |
| GET    | `/user/change-password`                   | changePasswordForm   | Shows the change password form          | Authenticated |
| POST   | `/user/update-password`                   | updatePassword       | Handles password change submission      | Authenticated |
| GET    | `/user/addresses`                         | showAddressBook      | Displays the user's address book        | Authenticated |
| GET    | `/user/addresses/add`                     | showAddAddressForm   | Shows the form to add a new address     | Authenticated |
| POST   | `/user/addresses/add`                     | processAddAddress    | Handles new address submission          | Authenticated |
| GET    | `/user/addresses/edit/{addressId}`        | showEditAddressForm  | Shows the form to edit an address       | Authenticated |
| POST   | `/user/addresses/edit/{addressId}`        | processEditAddress   | Handles address update submission       | Authenticated |
| POST   | `/user/addresses/delete/{addressId}`      | deleteAddress        | Deletes a user address                  | Authenticated |
| POST   | `/user/addresses/set-default/{addressId}` | setDefaultAddress    | Sets an address as default (ship/bill)  | Authenticated |

*(Note: Registration might be moved to a dedicated AuthController)*

---

**7. AdminProductController (Admin Product Management)**

| Method | URL Pattern                              | Action              | Description                            | Authorization |
| :----- | :--------------------------------------- | :------------------ | :------------------------------------- | :------------ |
| GET    | `/admin/products`                      | listProducts        | Displays paginated list of products    | Admin         |
| GET    | `/admin/products/add`                  | showAddProductForm  | Shows form to add a new product        | Admin         |
| POST   | `/admin/products/add`                  | processAddProduct   | Handles new product submission         | Admin         |
| GET    | `/admin/products/edit/{id}`            | showEditProductForm | Shows form to edit a product           | Admin         |
| POST   | `/admin/products/edit/{id}`            | processEditProduct  | Handles product update submission      | Admin         |
| POST   | `/admin/products/delete/{id}`          | deleteProduct       | Deletes a product                      | Admin         |
| POST   | `/admin/products/toggle-featured/{id}` | toggleFeatured      | Toggles featured status for a product  | Admin         |
| POST   | `/admin/products/toggle-new/{id}`      | toggleNewArrival    | Toggles new arrival status for product | Admin         |

---

**8. AdminCategoryController (Admin Category Management)**

| Method | URL Pattern                       | Action               | Description                           | Authorization |
| :----- | :-------------------------------- | :------------------- | :------------------------------------ | :------------ |
| GET    | `/admin/categories`             | listCategories       | Displays paginated list of categories | Admin         |
| GET    | `/admin/categories/add`         | showAddCategoryForm  | Shows form to add a new category      | Admin         |
| POST   | `/admin/categories/add`         | processAddCategory   | Handles new category submission       | Admin         |
| GET    | `/admin/categories/edit/{id}`   | showEditCategoryForm | Shows form to edit a category         | Admin         |
| POST   | `/admin/categories/edit/{id}`   | processEditCategory  | Handles category update submission    | Admin         |
| POST   | `/admin/categories/delete/{id}` | deleteCategory       | Deletes a category                    | Admin         |

---

**9. AdminBrandController (Admin Brand Management)**

| Method | URL Pattern                   | Action            | Description                       | Authorization |
| :----- | :---------------------------- | :---------------- | :-------------------------------- | :------------ |
| GET    | `/admin/brands`             | listBrands        | Displays paginated list of brands | Admin         |
| GET    | `/admin/brands/add`         | showAddBrandForm  | Shows form to add a new brand     | Admin         |
| POST   | `/admin/brands/add`         | processAddBrand   | Handles new brand submission      | Admin         |
| GET    | `/admin/brands/edit/{id}`   | showEditBrandForm | Shows form to edit a brand        | Admin         |
| POST   | `/admin/brands/edit/{id}`   | processEditBrand  | Handles brand update submission   | Admin         |
| POST   | `/admin/brands/delete/{id}` | deleteBrand       | Deletes a brand                   | Admin         |

---

**10. AdminWarrantyController (Admin Warranty Management)**

| Method | URL Pattern                       | Action               | Description                           | Authorization |
| :----- | :-------------------------------- | :------------------- | :------------------------------------ | :------------ |
| GET    | `/admin/warranties`             | listWarranties       | Displays paginated list of warranties | Admin         |
| GET    | `/admin/warranties/add`         | showAddWarrantyForm  | Shows form to add a new warranty      | Admin         |
| POST   | `/admin/warranties/add`         | processAddWarranty   | Handles new warranty submission       | Admin         |
| GET    | `/admin/warranties/edit/{id}`   | showEditWarrantyForm | Shows form to edit a warranty         | Admin         |
| POST   | `/admin/warranties/edit/{id}`   | processEditWarranty  | Handles warranty update submission    | Admin         |
| POST   | `/admin/warranties/delete/{id}` | deleteWarranty       | Deletes a warranty                    | Admin         |

---

**11. AdminOrderController (Admin Order Management)**

| Method | URL Pattern                                | Action                | Description                           | Authorization |
| :----- | :----------------------------------------- | :-------------------- | :------------------------------------ | :------------ |
| GET    | `/admin/orders`                          | listAllOrders         | Displays paginated list of all orders | Admin         |
| GET    | `/admin/orders/{orderId}`                | showAdminOrderDetails | Displays details of a specific order  | Admin         |
| POST   | `/admin/orders/update-status/{orderId}`  | updateOrderStatus     | Updates the order status              | Admin         |
| POST   | `/admin/orders/update-payment/{orderId}` | updatePaymentDetails  | Updates payment status/TrxID          | Admin         |
| POST   | `/admin/orders/cancel/{orderId}`         | cancelOrder           | Cancels an order                      | Admin         |

---

**12. AdminUserController (Admin User Management)**

| Method | URL Pattern                         | Action           | Description                         | Authorization |
| :----- | :---------------------------------- | :--------------- | :---------------------------------- | :------------ |
| GET    | `/admin/users`                    | listUsers        | Displays paginated list of users    | Admin         |
| GET    | `/admin/users/view/{id}`          | viewUserDetails  | Displays details of a specific user | Admin         |
| POST   | `/admin/users/toggle-status/{id}` | toggleUserStatus | Enables/Disables a user account     | Admin         |
| POST   | `/admin/users/update-roles/{id}`  | updateUserRoles  | Updates roles assigned to a user    | Admin         |

---

**13. AdminDashboardController (Admin Dashboard)**

| Method | URL Pattern          | Action        | Description                  | Authorization |
| :----- | :------------------- | :------------ | :--------------------------- | :------------ |
| GET    | `/admin/dashboard` | showDashboard | Displays the admin dashboard | Admin         |

---

This list covers the endpoints we've explicitly defined or implemented controllers for. Remember that Spring Security handles `/login` (POST) and `/logout` (POST) implicitly based on configuration unless customized heavily. Static resources (`/css/**`, `/js/**`, `/images/**`, etc.) are handled by resource handlers, not specific controller endpoints.


# Data Flow Diagram

**Level 1 DFD Processes for Electronics Store:**

1. User Authentication & Registration

* Process: 1.0 Register New User
* External Entity: User (Anonymous initially)
* Data Flows In: Registration Form Data (Name, Email, Phone, Password, Address?)
* Data Flows Out: Verification Email Trigger, User Account Record, Address Record?, Verification Token Record
* Data Stores Accessed: User Store, Address Store?, Verification Store
* Process: 2.0 Authenticate User
* External Entity: User
* Data Flows In: Login Credentials (Email, Password)
* Data Flows Out: Session/Authentication Token, Login Success/Failure
* Data Stores Accessed: User Store (Read), Role Store (Read)
* Process: 3.0 Verify Email
* External Entity: User
* Data Flows In: Verification Token (from email link)
* Data Flows Out: Account Enabled Status Update
* Data Stores Accessed: Verification Store (Read/Update), User Store (Update)
* Process: 4.0 Logout User
* External Entity: User
* Data Flows In: Logout Request
* Data Flows Out: Session Invalidation
* Data Stores Accessed: (None directly, handled by security framework)

2. User Profile & Address Management

* Process: 5.0 Manage User Profile
* External Entity: User
* Data Flows In: Profile Update Data (Name, Phone)
* Data Flows Out: Updated Profile View, Profile Data
* Data Stores Accessed: User Store (Read/Update)
* Process: 6.0 Manage Addresses
* External Entity: User
* Data Flows In: New Address Data, Updated Address Data, Delete Request, Set Default Request
* Data Flows Out: Address List View, Address Form View, Updated Address Record, Confirmation Messages
* Data Stores Accessed: Address Store (CRUD), User Store (Read)
* Process: 7.0 Change Password
* External Entity: User
* Data Flows In: Old Password, New Password, Confirm Password
* Data Flows Out: Password Update Confirmation/Error
* Data Stores Accessed: User Store (Read/Update)

3. Product Browsing & Search

* Process: 8.0 Browse/View Products
* External Entity: User (Anonymous or Authenticated)
* Data Flows In: Filter Criteria (Category ID, Brand ID, Price, New Arrival), Sort Criteria, Page Number, Search Query
* Data Flows Out: Product List (Paginated), Product Details View
* Data Stores Accessed: Product Store (Read), Category Store (Read), Brand Store (Read)

4. Shopping Cart Management

* Process: 9.0 Manage Cart Items
* External Entity: User
* Data Flows In: Product ID to Add, Quantity to Add, Cart Item ID to Update/Remove, Quantity to Update, Clear Cart Request
* Data Flows Out: Updated Cart View, Confirmation Messages
* Data Stores Accessed: Cart Store (CRUD), Product Store (Read - for stock/price), User Store (Read)

5. Checkout & Order Placement

* Process: 10.0 Process Checkout
* External Entity: User
* Data Flows In: Selected Shipping Address ID, Selected Payment Method
* Data Flows Out: Shipping Address View, Payment Method View, Order Review View, Checkout State (Session)
* Data Stores Accessed: Address Store (Read), Cart Store (Read), User Store (Read)
* Process: 11.0 Place Order
* External Entity: User
* Data Flows In: Checkout Confirmation (Implicit from submitting review)
* Data Flows Out: Order Record, OrderItem Records, Stock Level Update, Cleared Cart Items, Order Confirmation View/Email Trigger
* Data Stores Accessed: Order Store (Create), OrderItem Store (Create), Product Store (Update - stock), Cart Store (Delete), User Store (Read), Address Store (Read - for shipping details)
* Process: 12.0 Submit Payment Details
* External Entity: User
* Data Flows In: Transaction ID
* Data Flows Out: Updated Order Payment Status/TrxID
* Data Stores Accessed: Order Store (Update)

6. User Order Viewing

* Process: 13.0 View Order History/Details
* External Entity: User
* Data Flows In: Request for History (Paginated), Request for Specific Order ID
* Data Flows Out: Order History List (Paginated), Order Details View
* Data Stores Accessed: Order Store (Read), OrderItem Store (Read), Product Store (Read - for item details), User Store (Read)

7. Admin Product Catalog Management

* Process: 14.0 Manage Products (Admin)
* External Entity: Admin
* Data Flows In: Product Data (Create/Update), Product ID (Update/Delete), Image File, Toggle Status Request
* Data Flows Out: Product List View, Product Form View, Confirmation Messages
* Data Stores Accessed: Product Store (CRUD), Category Store (Read), Brand Store (Read), Warranty Store (Read)
* Process: 15.0 Manage Categories (Admin)
* External Entity: Admin
* Data Flows In: Category Data (Create/Update), Category ID (Update/Delete)
* Data Flows Out: Category List View, Category Form View, Confirmation Messages
* Data Stores Accessed: Category Store (CRUD), Product Store (Read - for delete check)
* Process: 16.0 Manage Brands (Admin)
* External Entity: Admin
* Data Flows In: Brand Data (Create/Update), Brand ID (Update/Delete), Logo File
* Data Flows Out: Brand List View, Brand Form View, Confirmation Messages
* Data Stores Accessed: Brand Store (CRUD), Product Store (Read - for delete check)
* Process: 17.0 Manage Warranties (Admin)
* External Entity: Admin
* Data Flows In: Warranty Data (Create/Update), Warranty ID (Update/Delete)
* Data Flows Out: Warranty List View, Warranty Form View, Confirmation Messages
* Data Stores Accessed: Warranty Store (CRUD), Product Store (Read - for delete check)

8. Admin Order Management

* Process: 18.0 View/Manage All Orders (Admin)
* External Entity: Admin
* Data Flows In: Filter Criteria (Status), Sort Criteria, Page Number, Order ID (for details), New Order Status, New Payment Status, Transaction ID, Cancel Request
* Data Flows Out: Order List View, Order Details View, Updated Order Status, Updated Payment Details, Confirmation Messages
* Data Stores Accessed: Order Store (Read/Update), User Store (Read - for customer details), OrderItem Store (Read), Product Store (Read - for item details)

9. Admin User Management

* Process: 19.0 Manage Users (Admin)
* External Entity: Admin
* Data Flows In: User ID (for details), Toggle Status Request, Updated Role IDs
* Data Flows Out: User List View, User Details View, Confirmation Messages
* Data Stores Accessed: User Store (Read/Update), Role Store (Read/Update via User)

10. Admin Dashboard

* Process: 20.0 View Dashboard
* External Entity: Admin
* Data Flows In: Request for Dashboard
* Data Flows Out: Dashboard View with Statistics (Counts, Revenue), Recent Orders List
* Data Stores Accessed: User Store (Read - count), Product Store (Read - count), Order Store (Read - count, sum, list), Category Store (Read - count), Brand Store (Read - count)

---
