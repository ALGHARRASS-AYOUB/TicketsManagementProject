﻿CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL,
    CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
);

START TRANSACTION;


DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20241017184827_InitialMigration') THEN
    CREATE TABLE "Tickets" (
        "TicketId" integer GENERATED BY DEFAULT AS IDENTITY,
        "Description" text NOT NULL,
        "Status" integer NOT NULL,
        "Date" timestamp with time zone NOT NULL,
        CONSTRAINT "PK_Tickets" PRIMARY KEY ("TicketId")
    );
    END IF;
END $EF$;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20241017184827_InitialMigration') THEN
    INSERT INTO "Tickets" ("TicketId", "Date", "Description", "Status")
    VALUES (1, TIMESTAMPTZ '2024-10-12T18:48:26.979604Z', 'desc 1 ', 0);
    INSERT INTO "Tickets" ("TicketId", "Date", "Description", "Status")
    VALUES (2, TIMESTAMPTZ '2024-10-14T18:48:26.979605Z', 'desc 2', 1);
    INSERT INTO "Tickets" ("TicketId", "Date", "Description", "Status")
    VALUES (3, TIMESTAMPTZ '2024-10-15T18:48:26.979605Z', 'desc 3', 0);
    INSERT INTO "Tickets" ("TicketId", "Date", "Description", "Status")
    VALUES (4, TIMESTAMPTZ '2024-10-16T18:48:26.979605Z', 'desc 4', 0);
    INSERT INTO "Tickets" ("TicketId", "Date", "Description", "Status")
    VALUES (5, TIMESTAMPTZ '2024-10-08T18:48:26.979605Z', 'desc 5 ', 0);
    INSERT INTO "Tickets" ("TicketId", "Date", "Description", "Status")
    VALUES (6, TIMESTAMPTZ '2024-10-14T18:48:26.979605Z', 'desc 6', 1);
    INSERT INTO "Tickets" ("TicketId", "Date", "Description", "Status")
    VALUES (7, TIMESTAMPTZ '2024-10-15T18:48:26.979606Z', 'desc 7', 0);
    INSERT INTO "Tickets" ("TicketId", "Date", "Description", "Status")
    VALUES (8, TIMESTAMPTZ '2024-10-16T18:48:26.979606Z', 'desc 8', 0);
    INSERT INTO "Tickets" ("TicketId", "Date", "Description", "Status")
    VALUES (9, TIMESTAMPTZ '2024-10-12T18:48:26.979606Z', 'desc 9 ', 0);
    INSERT INTO "Tickets" ("TicketId", "Date", "Description", "Status")
    VALUES (10, TIMESTAMPTZ '2024-10-14T18:48:26.979606Z', 'desc 10', 1);
    INSERT INTO "Tickets" ("TicketId", "Date", "Description", "Status")
    VALUES (11, TIMESTAMPTZ '2024-10-15T18:48:26.979606Z', 'desc 11', 0);
    INSERT INTO "Tickets" ("TicketId", "Date", "Description", "Status")
    VALUES (12, TIMESTAMPTZ '2024-10-16T18:48:26.979606Z', 'desc 12', 0);
    END IF;
END $EF$;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20241017184827_InitialMigration') THEN
    PERFORM setval(
        pg_get_serial_sequence('"Tickets"', 'TicketId'),
        GREATEST(
            (SELECT MAX("TicketId") FROM "Tickets") + 1,
            nextval(pg_get_serial_sequence('"Tickets"', 'TicketId'))),
        false);
    END IF;
END $EF$;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20241017184827_InitialMigration') THEN
    INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
    VALUES ('20241017184827_InitialMigration', '8.0.10');
    END IF;
END $EF$;
COMMIT;

START TRANSACTION;


DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20241019193410_Initial') THEN
    UPDATE "Tickets" SET "Date" = TIMESTAMPTZ '2024-10-14T19:34:10.144176Z'
    WHERE "TicketId" = 1;
    END IF;
END $EF$;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20241019193410_Initial') THEN
    UPDATE "Tickets" SET "Date" = TIMESTAMPTZ '2024-10-16T19:34:10.144177Z'
    WHERE "TicketId" = 2;
    END IF;
END $EF$;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20241019193410_Initial') THEN
    UPDATE "Tickets" SET "Date" = TIMESTAMPTZ '2024-10-17T19:34:10.144177Z'
    WHERE "TicketId" = 3;
    END IF;
END $EF$;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20241019193410_Initial') THEN
    UPDATE "Tickets" SET "Date" = TIMESTAMPTZ '2024-10-18T19:34:10.144177Z'
    WHERE "TicketId" = 4;
    END IF;
END $EF$;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20241019193410_Initial') THEN
    UPDATE "Tickets" SET "Date" = TIMESTAMPTZ '2024-10-10T19:34:10.144178Z'
    WHERE "TicketId" = 5;
    END IF;
END $EF$;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20241019193410_Initial') THEN
    UPDATE "Tickets" SET "Date" = TIMESTAMPTZ '2024-10-16T19:34:10.144178Z'
    WHERE "TicketId" = 6;
    END IF;
END $EF$;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20241019193410_Initial') THEN
    UPDATE "Tickets" SET "Date" = TIMESTAMPTZ '2024-10-17T19:34:10.144178Z'
    WHERE "TicketId" = 7;
    END IF;
END $EF$;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20241019193410_Initial') THEN
    UPDATE "Tickets" SET "Date" = TIMESTAMPTZ '2024-10-18T19:34:10.144178Z'
    WHERE "TicketId" = 8;
    END IF;
END $EF$;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20241019193410_Initial') THEN
    UPDATE "Tickets" SET "Date" = TIMESTAMPTZ '2024-10-14T19:34:10.144178Z'
    WHERE "TicketId" = 9;
    END IF;
END $EF$;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20241019193410_Initial') THEN
    UPDATE "Tickets" SET "Date" = TIMESTAMPTZ '2024-10-16T19:34:10.144178Z'
    WHERE "TicketId" = 10;
    END IF;
END $EF$;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20241019193410_Initial') THEN
    UPDATE "Tickets" SET "Date" = TIMESTAMPTZ '2024-10-17T19:34:10.144179Z'
    WHERE "TicketId" = 11;
    END IF;
END $EF$;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20241019193410_Initial') THEN
    UPDATE "Tickets" SET "Date" = TIMESTAMPTZ '2024-10-18T19:34:10.144179Z'
    WHERE "TicketId" = 12;
    END IF;
END $EF$;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20241019193410_Initial') THEN
    INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
    VALUES ('20241019193410_Initial', '8.0.10');
    END IF;
END $EF$;
COMMIT;
