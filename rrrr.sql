PGDMP                       }         
   restaurant    17.2    17.2 *    %           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                           false            &           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                           false            '           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                           false            (           1262    16566 
   restaurant    DATABASE     �   CREATE DATABASE restaurant WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_United States.1251';
    DROP DATABASE restaurant;
                     postgres    false            �            1259    16568    customer    TABLE     �   CREATE TABLE public.customer (
    customerid integer NOT NULL,
    name character varying(100) NOT NULL,
    email character varying(100) NOT NULL,
    phone character varying(15)
);
    DROP TABLE public.customer;
       public         heap r       postgres    false            �            1259    16567    customer_customerid_seq    SEQUENCE     �   CREATE SEQUENCE public.customer_customerid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE public.customer_customerid_seq;
       public               postgres    false    218            )           0    0    customer_customerid_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public.customer_customerid_seq OWNED BY public.customer.customerid;
          public               postgres    false    217            �            1259    16696    feedback    TABLE     �   CREATE TABLE public.feedback (
    feedbackid integer NOT NULL,
    customerid text NOT NULL,
    rating integer NOT NULL,
    comments text
);
    DROP TABLE public.feedback;
       public         heap r       postgres    false            �            1259    16615 	   inventory    TABLE     �   CREATE TABLE public.inventory (
    inventoryid integer NOT NULL,
    itemname character varying(100) NOT NULL,
    quantity integer NOT NULL
);
    DROP TABLE public.inventory;
       public         heap r       postgres    false            �            1259    16614    inventory_inventoryid_seq    SEQUENCE     �   CREATE SEQUENCE public.inventory_inventoryid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 0   DROP SEQUENCE public.inventory_inventoryid_seq;
       public               postgres    false    222            *           0    0    inventory_inventoryid_seq    SEQUENCE OWNED BY     W   ALTER SEQUENCE public.inventory_inventoryid_seq OWNED BY public.inventory.inventoryid;
          public               postgres    false    221            �            1259    16590    menuitem    TABLE     �   CREATE TABLE public.menuitem (
    menuitemid integer NOT NULL,
    name character varying(100) NOT NULL,
    price text NOT NULL,
    isavailable boolean DEFAULT true NOT NULL,
    recipe text
);
    DROP TABLE public.menuitem;
       public         heap r       postgres    false            �            1259    16589    menuitem_menuitemid_seq    SEQUENCE     �   CREATE SEQUENCE public.menuitem_menuitemid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE public.menuitem_menuitemid_seq;
       public               postgres    false    220            +           0    0    menuitem_menuitemid_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public.menuitem_menuitemid_seq OWNED BY public.menuitem.menuitemid;
          public               postgres    false    219            �            1259    16663    orderdetails    TABLE     �   CREATE TABLE public.orderdetails (
    orderdetailsid integer NOT NULL,
    item text NOT NULL,
    quantity integer NOT NULL
);
     DROP TABLE public.orderdetails;
       public         heap r       postgres    false            �            1259    16691    payment    TABLE     m   CREATE TABLE public.payment (
    paymentid integer NOT NULL,
    orderid integer,
    amountpaid integer
);
    DROP TABLE public.payment;
       public         heap r       postgres    false            �            1259    16634    staff    TABLE     �   CREATE TABLE public.staff (
    staffid integer NOT NULL,
    name character varying(100) NOT NULL,
    role character varying(50) NOT NULL
);
    DROP TABLE public.staff;
       public         heap r       postgres    false            �            1259    16633    staff_staffid_seq    SEQUENCE     �   CREATE SEQUENCE public.staff_staffid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 (   DROP SEQUENCE public.staff_staffid_seq;
       public               postgres    false    224            ,           0    0    staff_staffid_seq    SEQUENCE OWNED BY     G   ALTER SEQUENCE public.staff_staffid_seq OWNED BY public.staff.staffid;
          public               postgres    false    223            r           2604    16571    customer customerid    DEFAULT     z   ALTER TABLE ONLY public.customer ALTER COLUMN customerid SET DEFAULT nextval('public.customer_customerid_seq'::regclass);
 B   ALTER TABLE public.customer ALTER COLUMN customerid DROP DEFAULT;
       public               postgres    false    217    218    218            u           2604    16618    inventory inventoryid    DEFAULT     ~   ALTER TABLE ONLY public.inventory ALTER COLUMN inventoryid SET DEFAULT nextval('public.inventory_inventoryid_seq'::regclass);
 D   ALTER TABLE public.inventory ALTER COLUMN inventoryid DROP DEFAULT;
       public               postgres    false    221    222    222            s           2604    16593    menuitem menuitemid    DEFAULT     z   ALTER TABLE ONLY public.menuitem ALTER COLUMN menuitemid SET DEFAULT nextval('public.menuitem_menuitemid_seq'::regclass);
 B   ALTER TABLE public.menuitem ALTER COLUMN menuitemid DROP DEFAULT;
       public               postgres    false    220    219    220            v           2604    16637    staff staffid    DEFAULT     n   ALTER TABLE ONLY public.staff ALTER COLUMN staffid SET DEFAULT nextval('public.staff_staffid_seq'::regclass);
 <   ALTER TABLE public.staff ALTER COLUMN staffid DROP DEFAULT;
       public               postgres    false    223    224    224                      0    16568    customer 
   TABLE DATA           B   COPY public.customer (customerid, name, email, phone) FROM stdin;
    public               postgres    false    218   -.       "          0    16696    feedback 
   TABLE DATA           L   COPY public.feedback (feedbackid, customerid, rating, comments) FROM stdin;
    public               postgres    false    227   �.                 0    16615 	   inventory 
   TABLE DATA           D   COPY public.inventory (inventoryid, itemname, quantity) FROM stdin;
    public               postgres    false    222   /                 0    16590    menuitem 
   TABLE DATA           P   COPY public.menuitem (menuitemid, name, price, isavailable, recipe) FROM stdin;
    public               postgres    false    220   V/                  0    16663    orderdetails 
   TABLE DATA           F   COPY public.orderdetails (orderdetailsid, item, quantity) FROM stdin;
    public               postgres    false    225   �/       !          0    16691    payment 
   TABLE DATA           A   COPY public.payment (paymentid, orderid, amountpaid) FROM stdin;
    public               postgres    false    226   �/                 0    16634    staff 
   TABLE DATA           4   COPY public.staff (staffid, name, role) FROM stdin;
    public               postgres    false    224   90       -           0    0    customer_customerid_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.customer_customerid_seq', 6, true);
          public               postgres    false    217            .           0    0    inventory_inventoryid_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public.inventory_inventoryid_seq', 1, false);
          public               postgres    false    221            /           0    0    menuitem_menuitemid_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.menuitem_menuitemid_seq', 1, false);
          public               postgres    false    219            0           0    0    staff_staffid_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.staff_staffid_seq', 1, false);
          public               postgres    false    223            x           2606    16575    customer customer_email_key 
   CONSTRAINT     W   ALTER TABLE ONLY public.customer
    ADD CONSTRAINT customer_email_key UNIQUE (email);
 E   ALTER TABLE ONLY public.customer DROP CONSTRAINT customer_email_key;
       public                 postgres    false    218            z           2606    16573    customer customer_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.customer
    ADD CONSTRAINT customer_pkey PRIMARY KEY (customerid);
 @   ALTER TABLE ONLY public.customer DROP CONSTRAINT customer_pkey;
       public                 postgres    false    218            �           2606    16702    feedback feedback_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.feedback
    ADD CONSTRAINT feedback_pkey PRIMARY KEY (feedbackid);
 @   ALTER TABLE ONLY public.feedback DROP CONSTRAINT feedback_pkey;
       public                 postgres    false    227            ~           2606    16620    inventory inventory_pkey 
   CONSTRAINT     _   ALTER TABLE ONLY public.inventory
    ADD CONSTRAINT inventory_pkey PRIMARY KEY (inventoryid);
 B   ALTER TABLE ONLY public.inventory DROP CONSTRAINT inventory_pkey;
       public                 postgres    false    222            |           2606    16596    menuitem menuitem_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.menuitem
    ADD CONSTRAINT menuitem_pkey PRIMARY KEY (menuitemid);
 @   ALTER TABLE ONLY public.menuitem DROP CONSTRAINT menuitem_pkey;
       public                 postgres    false    220            �           2606    16669    orderdetails orderdetails_pkey 
   CONSTRAINT     h   ALTER TABLE ONLY public.orderdetails
    ADD CONSTRAINT orderdetails_pkey PRIMARY KEY (orderdetailsid);
 H   ALTER TABLE ONLY public.orderdetails DROP CONSTRAINT orderdetails_pkey;
       public                 postgres    false    225            �           2606    16695    payment payment_pkey 
   CONSTRAINT     Y   ALTER TABLE ONLY public.payment
    ADD CONSTRAINT payment_pkey PRIMARY KEY (paymentid);
 >   ALTER TABLE ONLY public.payment DROP CONSTRAINT payment_pkey;
       public                 postgres    false    226            �           2606    16639    staff staff_pkey 
   CONSTRAINT     S   ALTER TABLE ONLY public.staff
    ADD CONSTRAINT staff_pkey PRIMARY KEY (staffid);
 :   ALTER TABLE ONLY public.staff DROP CONSTRAINT staff_pkey;
       public                 postgres    false    224               ~   x�U���0뻏���y�h�"DZ�G)K���آ	�n��YW�9�(��n���5�y?V(-�.�v�,@�w��A������v�t�!�2�Z��s�D�?��
ԣ���rs�:3~W����1L      "   R   x���� �s;E'�{�G/���H�5�����;7м����uV�d��!�	&f����=-%����T<��4��x����         )   x�3126�IL�I�42�4�4�t�H�,�46����� ��          1   x�31661�.I��0 ��?.3S3Sΐ���BNsS�p� #*
�          P   x�3612��H,�����4�2566A����M�����DNS.#c��Ĉ3�$����4�2753��/+-���qqq ���      !   2   x���  �wR�#�@3�_��ۓR"j�X>(	'���e�g�E���            x������ � �     