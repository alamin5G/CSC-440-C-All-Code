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

### PRESENTATION SLIDE

## Slide 1: Title Slide

* **Title:** Electronics Store: A Full-Stack E-commerce Platform
* **Course:** CSC 470 - Final Project Presentation
* **Group Members:** [List Your Group Members Here]
* **Date:** [Date of Presentation]
* **(Optional):** University Logo / Course Logo

---

## Slide 2: Project Overview & Objectives

* **Goal:** To design and develop a functional, secure, and user-friendly e-commerce platform for selling electronics online.
* **Core Purpose:** Provide a seamless shopping experience for users and efficient management tools for administrators.
* **Key Functional Areas:**
  * User Authentication & Profile Management
  * Product Catalog Browsing, Searching & Filtering
  * Shopping Cart & Multi-Step Checkout Process
  * Order Placement & History Viewing
  * Admin Management (Products, Categories, Brands, Warranties, Orders, Users)
* **Target Users:** Anonymous Visitors, Registered Customers, Administrators.

---

## Slide 3: Technology Stack (Relates to A1: Resources)

* **Backend:** Java, Spring Boot 3+, Spring MVC, Spring Data JPA (Hibernate), Spring Security
* **Frontend:** Thymeleaf (Server-Side Rendering), HTML5, CSS3, Bootstrap 5, JavaScript (Minimal/Standard Bootstrap JS)
* **Database:** MySQL
* **Key Libraries:** Lombok, ModelMapper, Jakarta Validation
* **Build Tool:** Maven / Gradle (Specify which one you used)
* **Development Tools:** Git, IntelliJ IDEA / Eclipse, MySQL Workbench / DBeaver
* **Deployment (Conceptual):** Embedded Tomcat Server
* **(Talking Point):** Discuss *why* this stack was chosen (e.g., robustness of Spring Boot, rapid development, large community support, suitability of relational DB for e-commerce data, Thymeleaf for server-side rendering preference). This demonstrates understanding of resource selection (A1).

---

## Slide 4: System Architecture (Relates to A2: Interaction, P7: Interdependence)

* **(Diagram Recommended):** Include a simple Layered Architecture Diagram (Presentation -> Controller -> Service -> Repository -> Database).
* **Presentation Layer:** Thymeleaf templates (`*.html`) rendering dynamic HTML based on data from Controllers. Bootstrap 5 for styling and layout.
* **Controller Layer (`@Controller`, `@RestController`):** Handles HTTP requests, validates input (using DTOs), interacts with Service layer, prepares data (`Model`) for the View. (e.g., `ProductController`, `AdminProductController`, `UserController`).
* **Service Layer (`@Service`):** Encapsulates core business logic, orchestrates operations, manages transactions (`@Transactional`), interacts with Repositories. (e.g., `ProductService`, `OrderService`, `UserService`). Decouples Controllers from data access details.
* **Data Access Layer (`@Repository`):** Spring Data JPA interfaces (`JpaRepository`) interacting with the database via Hibernate ORM. Defines entities (`@Entity`) mapped to database tables. (e.g., `ProductRepository`, `OrderRepository`).
* **Database Layer (MySQL):** Persistent storage for all application data (Users, Products, Orders, etc.).
* **Cross-Cutting Concerns:**

  * **Security (Spring Security):** Integrated across layers via filter chains and method security (`@PreAuthorize`).
  * **DTOs:** Used as data carriers between layers (Controller <-> Service, Service -> View via Model) to ensure separation and tailor data.
* **(Talking Point):** Explain how requests flow through these layers (e.g., adding to cart). Highlight the separation of concerns and how components depend on each other (P7). Discuss how this structure helps manage interactions (A2).

---

## Slide 5: Core Features - User Workflow (Relates to Design/Dev of Solutions)

* **(Diagram Recommended):** Simple flowchart of the main user journey (Browse -> View Details -> Add to Cart -> Checkout -> Place Order -> Confirmation -> Order History).
* **Browsing/Filtering/Search:** Public access, uses `ProductController`, `ProductService`, `ProductRepository` with pagination (`Pageable`) and dynamic filtering.
* **Registration/Login:** Secure process using Spring Security, `UserService`, `PasswordEncoder`, email verification flow (token generation/validation).
* **Profile/Address Management:** Authenticated users manage data via `UserController`, `UserService`, `AddressService` (if separated), using DTOs for updates. Sidebar navigation (`user-sidebar` fragment).
* **Cart Management:** Authenticated users interact via `CartController` and `CartService`. `ShoppingCartItem` entity stores cart state. Stock checks performed.
* **Checkout:** Multi-step process managed by `CheckoutController` using session-scoped `CheckoutDto`. Involves `UserService` (for addresses) and `CartService`.
* **Order Placement:** Triggered by `CheckoutController`, executed by `OrderService.placeOrder` within a transaction, updating `Order`, `OrderItem`, `Product` (stock), and clearing the cart.
* **Order Viewing:** Authenticated users view history/details via `OrderController` and `OrderService`.
* **(Talking Point):** Emphasize how these features meet the core requirements of an e-commerce platform. Mention specific requirements from the document and how the implemented feature addresses it.

---

## Slide 6: Core Features - Admin Workflow (Relates to Design/Dev of Solutions)

* **Secure Access:** `/admin/**` paths protected by Spring Security (`hasRole('ADMIN')`).
* **Dashboard:** Central overview (`AdminDashboardController`) fetching stats via various services (`countTotalUsers`, `countTotalOrders`, etc.).
* **CRUD Operations:** Dedicated controllers (`AdminProductController`, `AdminCategoryController`, etc.) for managing Products, Categories, Brands, Warranties.

  * Use DTOs (`ProductDto`, `BrandDto`, etc.) for forms (`@Valid`, `BindingResult`).
  * Service layer handles business logic, validation (e.g., duplicate names), and repository interactions.
  * Image/Logo uploads handled in services, paths stored in entities.
* **Order Management:** Admins view all orders (`AdminOrderController`, `OrderService.getAllOrders`), filter by status, view details, update order status, update payment details (status, TrxID), and cancel orders.
* **User Management:** Admins view all users (`AdminUserController`, `UserService.getAllUsers`), view details, toggle enabled status, and update roles (`RoleRepository` used to fetch roles).
* **(Talking Point):** Explain how these features provide necessary control and oversight for store administrators, fulfilling specific administrative requirements.

---

## Slide 7: Analysis - A1: Range of Resources (Examples)

* **Human:** Backend (Spring, JPA, Security), Frontend (Thymeleaf, Bootstrap), QA (Testing flows), PM (Coordination). *Challenge: Ensuring effective communication between backend/frontend.*
* **Technical:** Java 17+, Spring Boot 3+, Spring Data JPA, Spring Security, Thymeleaf, MySQL, Maven/Gradle, Git, Bootstrap 5, ModelMapper, Lombok. *Challenge: Managing dependencies and versions.*
* **Infrastructure:** Dev Machines, Hosting Server (Cloud/On-prem), Database Server/Service, Network. *Challenge: Ensuring environment consistency (Dev/Test/Prod).*
* **Data:** User credentials (hashed), Product Catalog, Order History, Addresses, Session data (`CheckoutDto`). *Challenge: Data security, privacy compliance, schema evolution.*
* **Interaction Example:** A backend developer changes a `Product` entity field. This requires updating the `ProductDto`, the `ProductService` mapping, the `AdminProductController` handling, and the Thymeleaf template (`admin/product-form.html`) used by the frontend developer. Git helps manage code changes, but communication is key.

*(Expand with more specific examples and challenges encountered).*

---

## Slide 8: Analysis - A2: Level of Interaction (Examples)

* **Frontend <-> Backend:**
  * *Problem:* Thymeleaf form (`th:object`) expecting fields not present in the submitted DTO (e.g., `email` in `UserProfileUpdateDto`).
  * *Resolution:* Refining DTOs for specific use cases, ensuring controller passes the correct object, using separate DTOs for display vs. update where necessary. Displaying read-only data from a different model attribute (`userProfileDisplay`).
* **Service <-> Data Layer:**
  * *Problem:* `ConstraintViolationException` when saving `Address` during registration due to `user_id` being null (premature cascade).
  * *Resolution:* Modified `UserService.registerUser` to save `User` first, then explicitly set the saved `User` on the `Address` *before* saving the `Address`. Managed transaction boundaries with `@Transactional`.
  * *Problem:* Ensuring atomicity during `placeOrder` (updating stock, creating order/items, clearing cart).
  * *Resolution:* Using `@Transactional` on the `OrderService.placeOrder` method ensures all database operations succeed or roll back together. Added explicit stock checks within the transaction.
* **Security <-> Application:**
  * *Problem:* Static resources (CSS, images) blocked by security rules.
  * *Resolution:* Explicitly adding `/css/**`, `/product-images/**`, etc., to `permitAll()` rules in `SecurityConfig`.
  * *Problem:* Ensuring only Admins can access `/admin/**` URLs.
  * *Resolution:* Using `requestMatchers("/admin/**").hasRole("ADMIN")` in `SecurityConfig` and `@PreAuthorize("hasRole('ADMIN')")` on admin controllers.

*(Expand with specific examples of debugging interactions, how DTOs helped, how transactions were managed, and specific security configurations).*

---

## Slide 9: Analysis - A5: Familiarity (Examples)

* **Unfamiliar Frameworks/Concepts:**
  * Spring Boot IoC/DI: Understanding bean lifecycle, scopes, `@Autowired`.
  * Spring Data JPA: Entity mapping, relationships (`mappedBy`, `CascadeType`, `FetchType`), derived queries, `@Transactional`. *Challenge Example: Debugging `LazyInitializationException` required understanding fetch types.*
  * Spring Security: `SecurityFilterChain`, `UserDetailsService`, `PasswordEncoder`, authorization rules. *Challenge Example: Configuring `formLogin()` and public/protected URL patterns correctly.*
  * Thymeleaf: Syntax (`th:*`), expression utilities (`#fields`, `#authorization`), layout dialect. *Challenge Example: Resolving errors related to using `#request` or duplicate attributes.*
* **Unfamiliar Patterns:**
  * MVC architecture and strict layer separation.
  * Using DTOs for data transfer.
* **New Challenges:**
  * Session management for multi-step checkout (`@SessionAttributes`).
  * File upload handling and storage (`MultipartFile`, `Paths`, configuration properties).
  * Implementing complex, multi-parameter filtering (`getFilteredProducts`).
* **Handling Unfamiliarity:**
  * **Key Resource:** Heavy reliance on official Spring/Thymeleaf/Bootstrap documentation.
  * **Debugging:** Using IDE debugger and extensive logging (`log.info`, `log.debug`) was critical (e.g., tracing the address saving constraint violation, debugging navbar model attributes).
  * **Problem Decomposition:** Building features incrementally (Admin CRUD first, then User flows).
  * **Online Resources:** Using Stack Overflow, Baeldung, etc., for specific error resolution and examples.
  * **Applying Principles:** When errors occurred, analyzing the request flow, data lifecycle, and transaction boundaries helped identify root causes.

*(Expand with specific framework features that were new, challenging errors encountered, how documentation/debugging helped, and specific principles applied to solve problems).*

---

## Slide 10: Demonstration (Optional but Recommended)

* Brief live demonstration of key features:
  * User Registration & Login
  * Browsing/Filtering Products
  * Adding to Cart & Checkout Process
  * Viewing Order History
  * Admin Login
  * Admin Product Management (Show list/add/edit)
  * Admin Order Management (Show list/details/update status)
  * Admin User Management (Show list/details/toggle status)

---

## Slide 11: Conclusion & Future Work

* **Summary:** Successfully developed a functional e-commerce platform demonstrating complex engineering activities through resource management (A1), component interaction (A2), and adaptation to unfamiliar technologies (A5). Leveraged Spring Boot, JPA, Security, and Thymeleaf to meet core requirements.
* **Key Achievements:** Implemented end-to-end user shopping flow and comprehensive admin management modules. Addressed challenges related to data integrity, security configuration, and framework complexities.
* **Future Work:**
  * Implement Password Recovery Flow.
  * Full Payment Gateway Integration & Manual Payment Verification Refinement.
  * Implement Email Notifications (Order Confirmation, etc.).
  * Refine UI/UX based on user feedback.
  * Enhance Admin Dashboard with more analytics.
  * Implement comprehensive testing suite (Unit, Integration, E2E).
  * Security Hardening (CSRF review, advanced input validation).

---

## Slide 12: Q&A

* Thank you. Questions?

---
