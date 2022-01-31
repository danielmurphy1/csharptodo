--
-- PostgreSQL database dump
--

-- Dumped from database version 13.3
-- Dumped by pg_dump version 13.3

-- Started on 2022-01-30 21:19:49

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 2990 (class 1262 OID 41661)
-- Name: test_todos; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE test_todos WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'English_United States.1252';


ALTER DATABASE test_todos OWNER TO postgres;

\connect test_todos

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 201 (class 1259 OID 41677)
-- Name: test_todos_info; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.test_todos_info (
    id integer NOT NULL,
    todo_text character varying(300) NOT NULL,
    is_complete boolean DEFAULT false,
    created_at timestamp with time zone DEFAULT CURRENT_TIMESTAMP
);


ALTER TABLE public.test_todos_info OWNER TO postgres;

--
-- TOC entry 200 (class 1259 OID 41675)
-- Name: test_todos_info_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.test_todos_info_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.test_todos_info_id_seq OWNER TO postgres;

--
-- TOC entry 2991 (class 0 OID 0)
-- Dependencies: 200
-- Name: test_todos_info_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.test_todos_info_id_seq OWNED BY public.test_todos_info.id;


--
-- TOC entry 2850 (class 2604 OID 41680)
-- Name: test_todos_info id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.test_todos_info ALTER COLUMN id SET DEFAULT nextval('public.test_todos_info_id_seq'::regclass);


--
-- TOC entry 2854 (class 2606 OID 41684)
-- Name: test_todos_info test_todos_info_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.test_todos_info
    ADD CONSTRAINT test_todos_info_pkey PRIMARY KEY (id);


-- Completed on 2022-01-30 21:19:49

--
-- PostgreSQL database dump complete
--

