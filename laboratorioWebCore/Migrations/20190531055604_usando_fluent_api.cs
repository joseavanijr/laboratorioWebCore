using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LaboratorioWebCore.Migrations
{
    public partial class usando_fluent_api : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamesDoAtendimento_Atendimentos_AtendimentoId",
                table: "ExamesDoAtendimento");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamesDoAtendimento_Exames_ExameId",
                table: "ExamesDoAtendimento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExamesDoAtendimento",
                table: "ExamesDoAtendimento");

            migrationBuilder.DropColumn(
                name: "ValorTotal",
                table: "Atendimentos");

            migrationBuilder.RenameTable(
                name: "ExamesDoAtendimento",
                newName: "ExamesDosAtendimentos");

            migrationBuilder.RenameColumn(
                name: "EnumTipoConveniado",
                table: "Pacientes",
                newName: "TipoConveniado");

            migrationBuilder.RenameIndex(
                name: "IX_ExamesDoAtendimento_ExameId",
                table: "ExamesDosAtendimentos",
                newName: "IX_ExamesDosAtendimentos_ExameId");

            migrationBuilder.RenameIndex(
                name: "IX_ExamesDoAtendimento_AtendimentoId",
                table: "ExamesDosAtendimentos",
                newName: "IX_ExamesDosAtendimentos_AtendimentoId");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "PlanosDeSaude",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Pacientes",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNascimento",
                table: "Pacientes",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cidades",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Atendimentos",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "ExamesDosAtendimentos",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExamesDosAtendimentos",
                table: "ExamesDosAtendimentos",
                column: "ExamesDoAtendimentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamesDosAtendimentos_Atendimentos_AtendimentoId",
                table: "ExamesDosAtendimentos",
                column: "AtendimentoId",
                principalTable: "Atendimentos",
                principalColumn: "AtendimentoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamesDosAtendimentos_Exames_ExameId",
                table: "ExamesDosAtendimentos",
                column: "ExameId",
                principalTable: "Exames",
                principalColumn: "ExameId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamesDosAtendimentos_Atendimentos_AtendimentoId",
                table: "ExamesDosAtendimentos");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamesDosAtendimentos_Exames_ExameId",
                table: "ExamesDosAtendimentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExamesDosAtendimentos",
                table: "ExamesDosAtendimentos");

            migrationBuilder.RenameTable(
                name: "ExamesDosAtendimentos",
                newName: "ExamesDoAtendimento");

            migrationBuilder.RenameColumn(
                name: "TipoConveniado",
                table: "Pacientes",
                newName: "EnumTipoConveniado");

            migrationBuilder.RenameIndex(
                name: "IX_ExamesDosAtendimentos_ExameId",
                table: "ExamesDoAtendimento",
                newName: "IX_ExamesDoAtendimento_ExameId");

            migrationBuilder.RenameIndex(
                name: "IX_ExamesDosAtendimentos_AtendimentoId",
                table: "ExamesDoAtendimento",
                newName: "IX_ExamesDoAtendimento_AtendimentoId");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "PlanosDeSaude",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Pacientes",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNascimento",
                table: "Pacientes",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cidades",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Atendimentos",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 15);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorTotal",
                table: "Atendimentos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "ExamesDoAtendimento",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 15);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExamesDoAtendimento",
                table: "ExamesDoAtendimento",
                column: "ExamesDoAtendimentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamesDoAtendimento_Atendimentos_AtendimentoId",
                table: "ExamesDoAtendimento",
                column: "AtendimentoId",
                principalTable: "Atendimentos",
                principalColumn: "AtendimentoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamesDoAtendimento_Exames_ExameId",
                table: "ExamesDoAtendimento",
                column: "ExameId",
                principalTable: "Exames",
                principalColumn: "ExameId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
