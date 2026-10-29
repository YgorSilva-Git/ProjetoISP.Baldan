using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoISP.Baldan.Migrations
{
    /// <inheritdoc />
    public partial class NovoDER : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistoricoPrazo5W2H_PlanoAcao5W2H_PlanoAcao5W2Hid",
                table: "HistoricoPrazo5W2H");

            migrationBuilder.DropForeignKey(
                name: "FK_InspecaoISP_SetorArea_SetorAreaid",
                table: "InspecaoISP");

            migrationBuilder.DropForeignKey(
                name: "FK_InspecaoISP_Usuario_Usuarioid",
                table: "InspecaoISP");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanoAcao5W2H_NaoConformidade_NaoConformidadeid",
                table: "PlanoAcao5W2H");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_PerfilAcesso_PerfilAcessoid",
                table: "Usuario");

            migrationBuilder.DropTable(
                name: "EvidenciaFotografica");

            migrationBuilder.DropTable(
                name: "NaoConformidade");

            migrationBuilder.DropTable(
                name: "ParticipanteInspecao");

            migrationBuilder.DropTable(
                name: "PerfilAcesso");

            migrationBuilder.DropTable(
                name: "SetorPergunta");

            migrationBuilder.DropTable(
                name: "RespostaChecklist");

            migrationBuilder.DropTable(
                name: "PerguntaChecklist");

            migrationBuilder.DropTable(
                name: "CategoriaPergunta");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_PerfilAcessoid",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlanoAcao5W2H",
                table: "PlanoAcao5W2H");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InspecaoISP",
                table: "InspecaoISP");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HistoricoPrazo5W2H",
                table: "HistoricoPrazo5W2H");

            migrationBuilder.DropColumn(
                name: "PerfilAcessoid",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "ComoSeraRealizada",
                table: "PlanoAcao5W2H");

            migrationBuilder.DropColumn(
                name: "CustoEstimado",
                table: "PlanoAcao5W2H");

            migrationBuilder.DropColumn(
                name: "JustificativaRecusa",
                table: "PlanoAcao5W2H");

            migrationBuilder.DropColumn(
                name: "OQueSeraFeito",
                table: "PlanoAcao5W2H");

            migrationBuilder.DropColumn(
                name: "OndeSeraRealizada",
                table: "PlanoAcao5W2H");

            migrationBuilder.DropColumn(
                name: "PrazoLimite",
                table: "PlanoAcao5W2H");

            migrationBuilder.DropColumn(
                name: "Responsavel",
                table: "PlanoAcao5W2H");

            migrationBuilder.DropColumn(
                name: "DataInspecao",
                table: "InspecaoISP");

            migrationBuilder.DropColumn(
                name: "EhRetroativo",
                table: "InspecaoISP");

            migrationBuilder.DropColumn(
                name: "DataModificacao",
                table: "HistoricoPrazo5W2H");

            migrationBuilder.RenameTable(
                name: "PlanoAcao5W2H",
                newName: "PLANOS_ACAO");

            migrationBuilder.RenameTable(
                name: "InspecaoISP",
                newName: "INSPECOES");

            migrationBuilder.RenameTable(
                name: "HistoricoPrazo5W2H",
                newName: "HISTORICO_PLANOS_ACAO");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "PLANOS_ACAO",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PLANOS_ACAO",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "NaoConformidadeid",
                table: "PLANOS_ACAO",
                newName: "id_resultado_inspecao");

            migrationBuilder.RenameIndex(
                name: "IX_PlanoAcao5W2H_NaoConformidadeid",
                table: "PLANOS_ACAO",
                newName: "IX_PLANOS_ACAO_id_resultado_inspecao");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "INSPECOES",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "INSPECOES",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Usuarioid",
                table: "INSPECOES",
                newName: "id_setor");

            migrationBuilder.RenameColumn(
                name: "SetorAreaid",
                table: "INSPECOES",
                newName: "id_modelo_checklist");

            migrationBuilder.RenameIndex(
                name: "IX_InspecaoISP_Usuarioid",
                table: "INSPECOES",
                newName: "IX_INSPECOES_id_setor");

            migrationBuilder.RenameIndex(
                name: "IX_InspecaoISP_SetorAreaid",
                table: "INSPECOES",
                newName: "IX_INSPECOES_id_modelo_checklist");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "HISTORICO_PLANOS_ACAO",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "PrazoAnterior",
                table: "HISTORICO_PLANOS_ACAO",
                newName: "Prazo_Anterior");

            migrationBuilder.RenameColumn(
                name: "NovoPrazo",
                table: "HISTORICO_PLANOS_ACAO",
                newName: "Novo_Prazo");

            migrationBuilder.RenameColumn(
                name: "MotivoAlteracao",
                table: "HISTORICO_PLANOS_ACAO",
                newName: "Motivo_Alteracao");

            migrationBuilder.RenameColumn(
                name: "PlanoAcao5W2Hid",
                table: "HISTORICO_PLANOS_ACAO",
                newName: "id_planos_acao");

            migrationBuilder.RenameIndex(
                name: "IX_HistoricoPrazo5W2H_PlanoAcao5W2Hid",
                table: "HISTORICO_PLANOS_ACAO",
                newName: "IX_HISTORICO_PLANOS_ACAO_id_planos_acao");

            migrationBuilder.AddColumn<string>(
                name: "Cargo",
                table: "Usuario",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "PerfildeAcesso",
                table: "Usuario",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "SetorArea",
                type: "varchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Unidadeid",
                table: "SetorArea",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "data",
                table: "SetorArea",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "url_foto_equipe",
                table: "SetorArea",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "acao_corretiva",
                table: "PLANOS_ACAO",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "descricao_desvio",
                table: "PLANOS_ACAO",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "id_responsavel_usuario",
                table: "PLANOS_ACAO",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "prazo",
                table: "PLANOS_ACAO",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "data_hora_fim",
                table: "INSPECOES",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "data_hora_inicio",
                table: "INSPECOES",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "id_inspetor_usuario",
                table: "INSPECOES",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Prazo_Anterior",
                table: "HISTORICO_PLANOS_ACAO",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Novo_Prazo",
                table: "HISTORICO_PLANOS_ACAO",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<string>(
                name: "Motivo_Alteracao",
                table: "HISTORICO_PLANOS_ACAO",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "Data_Alteracao",
                table: "HISTORICO_PLANOS_ACAO",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_PLANOS_ACAO",
                table: "PLANOS_ACAO",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_INSPECOES",
                table: "INSPECOES",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HISTORICO_PLANOS_ACAO",
                table: "HISTORICO_PLANOS_ACAO",
                column: "id");

            migrationBuilder.CreateTable(
                name: "CATEGORIAS",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORIAS", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Unidade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cidade = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidade", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MODELOS_CHECKLIST",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(150)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    versao = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    status = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    data = table.Column<DateTime>(type: "date", nullable: false),
                    id_categoria = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MODELOS_CHECKLIST", x => x.id);
                    table.ForeignKey(
                        name: "FK_MODELOS_CHECKLIST_CATEGORIAS_id_categoria",
                        column: x => x.id_categoria,
                        principalTable: "CATEGORIAS",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ITENS_CHECKLIST",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descricao_pergunta = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tipo_resposta = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    data = table.Column<DateTime>(type: "date", nullable: false),
                    id_checklist = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITENS_CHECKLIST", x => x.id);
                    table.ForeignKey(
                        name: "FK_ITENS_CHECKLIST_MODELOS_CHECKLIST_id_checklist",
                        column: x => x.id_checklist,
                        principalTable: "MODELOS_CHECKLIST",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RESULTADOS_INSPECAO",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    resposta_coletada = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    observacoes = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    url_foto_evidencia = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id_inspecao = table.Column<int>(type: "int", nullable: false),
                    id_item_checklist = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RESULTADOS_INSPECAO", x => x.id);
                    table.ForeignKey(
                        name: "FK_RESULTADOS_INSPECAO_INSPECOES_id_inspecao",
                        column: x => x.id_inspecao,
                        principalTable: "INSPECOES",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RESULTADOS_INSPECAO_ITENS_CHECKLIST_id_item_checklist",
                        column: x => x.id_item_checklist,
                        principalTable: "ITENS_CHECKLIST",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_SetorArea_Unidadeid",
                table: "SetorArea",
                column: "Unidadeid");

            migrationBuilder.CreateIndex(
                name: "IX_PLANOS_ACAO_id_responsavel_usuario",
                table: "PLANOS_ACAO",
                column: "id_responsavel_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_INSPECOES_id_inspetor_usuario",
                table: "INSPECOES",
                column: "id_inspetor_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_ITENS_CHECKLIST_id_checklist",
                table: "ITENS_CHECKLIST",
                column: "id_checklist");

            migrationBuilder.CreateIndex(
                name: "IX_MODELOS_CHECKLIST_id_categoria",
                table: "MODELOS_CHECKLIST",
                column: "id_categoria");

            migrationBuilder.CreateIndex(
                name: "IX_RESULTADOS_INSPECAO_id_inspecao",
                table: "RESULTADOS_INSPECAO",
                column: "id_inspecao");

            migrationBuilder.CreateIndex(
                name: "IX_RESULTADOS_INSPECAO_id_item_checklist",
                table: "RESULTADOS_INSPECAO",
                column: "id_item_checklist");

            migrationBuilder.AddForeignKey(
                name: "FK_HISTORICO_PLANOS_ACAO_PLANOS_ACAO_id_planos_acao",
                table: "HISTORICO_PLANOS_ACAO",
                column: "id_planos_acao",
                principalTable: "PLANOS_ACAO",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_INSPECOES_MODELOS_CHECKLIST_id_modelo_checklist",
                table: "INSPECOES",
                column: "id_modelo_checklist",
                principalTable: "MODELOS_CHECKLIST",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_INSPECOES_SetorArea_id_setor",
                table: "INSPECOES",
                column: "id_setor",
                principalTable: "SetorArea",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_INSPECOES_Usuario_id_inspetor_usuario",
                table: "INSPECOES",
                column: "id_inspetor_usuario",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PLANOS_ACAO_RESULTADOS_INSPECAO_id_resultado_inspecao",
                table: "PLANOS_ACAO",
                column: "id_resultado_inspecao",
                principalTable: "RESULTADOS_INSPECAO",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PLANOS_ACAO_Usuario_id_responsavel_usuario",
                table: "PLANOS_ACAO",
                column: "id_responsavel_usuario",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SetorArea_Unidade_Unidadeid",
                table: "SetorArea",
                column: "Unidadeid",
                principalTable: "Unidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HISTORICO_PLANOS_ACAO_PLANOS_ACAO_id_planos_acao",
                table: "HISTORICO_PLANOS_ACAO");

            migrationBuilder.DropForeignKey(
                name: "FK_INSPECOES_MODELOS_CHECKLIST_id_modelo_checklist",
                table: "INSPECOES");

            migrationBuilder.DropForeignKey(
                name: "FK_INSPECOES_SetorArea_id_setor",
                table: "INSPECOES");

            migrationBuilder.DropForeignKey(
                name: "FK_INSPECOES_Usuario_id_inspetor_usuario",
                table: "INSPECOES");

            migrationBuilder.DropForeignKey(
                name: "FK_PLANOS_ACAO_RESULTADOS_INSPECAO_id_resultado_inspecao",
                table: "PLANOS_ACAO");

            migrationBuilder.DropForeignKey(
                name: "FK_PLANOS_ACAO_Usuario_id_responsavel_usuario",
                table: "PLANOS_ACAO");

            migrationBuilder.DropForeignKey(
                name: "FK_SetorArea_Unidade_Unidadeid",
                table: "SetorArea");

            migrationBuilder.DropTable(
                name: "RESULTADOS_INSPECAO");

            migrationBuilder.DropTable(
                name: "Unidade");

            migrationBuilder.DropTable(
                name: "ITENS_CHECKLIST");

            migrationBuilder.DropTable(
                name: "MODELOS_CHECKLIST");

            migrationBuilder.DropTable(
                name: "CATEGORIAS");

            migrationBuilder.DropIndex(
                name: "IX_SetorArea_Unidadeid",
                table: "SetorArea");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PLANOS_ACAO",
                table: "PLANOS_ACAO");

            migrationBuilder.DropIndex(
                name: "IX_PLANOS_ACAO_id_responsavel_usuario",
                table: "PLANOS_ACAO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_INSPECOES",
                table: "INSPECOES");

            migrationBuilder.DropIndex(
                name: "IX_INSPECOES_id_inspetor_usuario",
                table: "INSPECOES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HISTORICO_PLANOS_ACAO",
                table: "HISTORICO_PLANOS_ACAO");

            migrationBuilder.DropColumn(
                name: "Cargo",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "PerfildeAcesso",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Unidadeid",
                table: "SetorArea");

            migrationBuilder.DropColumn(
                name: "data",
                table: "SetorArea");

            migrationBuilder.DropColumn(
                name: "url_foto_equipe",
                table: "SetorArea");

            migrationBuilder.DropColumn(
                name: "acao_corretiva",
                table: "PLANOS_ACAO");

            migrationBuilder.DropColumn(
                name: "descricao_desvio",
                table: "PLANOS_ACAO");

            migrationBuilder.DropColumn(
                name: "id_responsavel_usuario",
                table: "PLANOS_ACAO");

            migrationBuilder.DropColumn(
                name: "prazo",
                table: "PLANOS_ACAO");

            migrationBuilder.DropColumn(
                name: "data_hora_fim",
                table: "INSPECOES");

            migrationBuilder.DropColumn(
                name: "data_hora_inicio",
                table: "INSPECOES");

            migrationBuilder.DropColumn(
                name: "id_inspetor_usuario",
                table: "INSPECOES");

            migrationBuilder.DropColumn(
                name: "Data_Alteracao",
                table: "HISTORICO_PLANOS_ACAO");

            migrationBuilder.RenameTable(
                name: "PLANOS_ACAO",
                newName: "PlanoAcao5W2H");

            migrationBuilder.RenameTable(
                name: "INSPECOES",
                newName: "InspecaoISP");

            migrationBuilder.RenameTable(
                name: "HISTORICO_PLANOS_ACAO",
                newName: "HistoricoPrazo5W2H");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "PlanoAcao5W2H",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "PlanoAcao5W2H",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id_resultado_inspecao",
                table: "PlanoAcao5W2H",
                newName: "NaoConformidadeid");

            migrationBuilder.RenameIndex(
                name: "IX_PLANOS_ACAO_id_resultado_inspecao",
                table: "PlanoAcao5W2H",
                newName: "IX_PlanoAcao5W2H_NaoConformidadeid");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "InspecaoISP",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "InspecaoISP",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id_setor",
                table: "InspecaoISP",
                newName: "Usuarioid");

            migrationBuilder.RenameColumn(
                name: "id_modelo_checklist",
                table: "InspecaoISP",
                newName: "SetorAreaid");

            migrationBuilder.RenameIndex(
                name: "IX_INSPECOES_id_setor",
                table: "InspecaoISP",
                newName: "IX_InspecaoISP_Usuarioid");

            migrationBuilder.RenameIndex(
                name: "IX_INSPECOES_id_modelo_checklist",
                table: "InspecaoISP",
                newName: "IX_InspecaoISP_SetorAreaid");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "HistoricoPrazo5W2H",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Prazo_Anterior",
                table: "HistoricoPrazo5W2H",
                newName: "PrazoAnterior");

            migrationBuilder.RenameColumn(
                name: "Novo_Prazo",
                table: "HistoricoPrazo5W2H",
                newName: "NovoPrazo");

            migrationBuilder.RenameColumn(
                name: "Motivo_Alteracao",
                table: "HistoricoPrazo5W2H",
                newName: "MotivoAlteracao");

            migrationBuilder.RenameColumn(
                name: "id_planos_acao",
                table: "HistoricoPrazo5W2H",
                newName: "PlanoAcao5W2Hid");

            migrationBuilder.RenameIndex(
                name: "IX_HISTORICO_PLANOS_ACAO_id_planos_acao",
                table: "HistoricoPrazo5W2H",
                newName: "IX_HistoricoPrazo5W2H_PlanoAcao5W2Hid");

            migrationBuilder.AddColumn<int>(
                name: "PerfilAcessoid",
                table: "Usuario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "SetorArea",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)",
                oldMaxLength: 150)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ComoSeraRealizada",
                table: "PlanoAcao5W2H",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<decimal>(
                name: "CustoEstimado",
                table: "PlanoAcao5W2H",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "JustificativaRecusa",
                table: "PlanoAcao5W2H",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "OQueSeraFeito",
                table: "PlanoAcao5W2H",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "OndeSeraRealizada",
                table: "PlanoAcao5W2H",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "PrazoLimite",
                table: "PlanoAcao5W2H",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Responsavel",
                table: "PlanoAcao5W2H",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInspecao",
                table: "InspecaoISP",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "EhRetroativo",
                table: "InspecaoISP",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PrazoAnterior",
                table: "HistoricoPrazo5W2H",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NovoPrazo",
                table: "HistoricoPrazo5W2H",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "MotivoAlteracao",
                table: "HistoricoPrazo5W2H",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataModificacao",
                table: "HistoricoPrazo5W2H",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlanoAcao5W2H",
                table: "PlanoAcao5W2H",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InspecaoISP",
                table: "InspecaoISP",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HistoricoPrazo5W2H",
                table: "HistoricoPrazo5W2H",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CategoriaPergunta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaPergunta", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EvidenciaFotografica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PlanoAcao5W2Hid = table.Column<int>(type: "int", nullable: false),
                    CaminhoArquivo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataUpload = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvidenciaFotografica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EvidenciaFotografica_PlanoAcao5W2H_PlanoAcao5W2Hid",
                        column: x => x.PlanoAcao5W2Hid,
                        principalTable: "PlanoAcao5W2H",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ParticipanteInspecao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    InspecaoISPid = table.Column<int>(type: "int", nullable: false),
                    CaminhoFotoEquipe = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NomeParticipante = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipanteInspecao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParticipanteInspecao_InspecaoISP_InspecaoISPid",
                        column: x => x.InspecaoISPid,
                        principalTable: "InspecaoISP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PerfilAcesso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerfilAcesso", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PerguntaChecklist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CategoriaPerguntoId = table.Column<int>(type: "int", nullable: false),
                    Ativo = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TextoPergunta = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerguntaChecklist", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerguntaChecklist_CategoriaPergunta_CategoriaPerguntoId",
                        column: x => x.CategoriaPerguntoId,
                        principalTable: "CategoriaPergunta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RespostaChecklist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    InspecaoISPid = table.Column<int>(type: "int", nullable: false),
                    PerguntaChecklistid = table.Column<int>(type: "int", nullable: false),
                    Resposta = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RespostaChecklist", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RespostaChecklist_InspecaoISP_InspecaoISPid",
                        column: x => x.InspecaoISPid,
                        principalTable: "InspecaoISP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RespostaChecklist_PerguntaChecklist_PerguntaChecklistid",
                        column: x => x.PerguntaChecklistid,
                        principalTable: "PerguntaChecklist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SetorPergunta",
                columns: table => new
                {
                    SetorAreaid = table.Column<int>(type: "int", nullable: false),
                    PerguntaChecklistid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetorPergunta", x => new { x.SetorAreaid, x.PerguntaChecklistid });
                    table.ForeignKey(
                        name: "FK_SetorPergunta_PerguntaChecklist_PerguntaChecklistid",
                        column: x => x.PerguntaChecklistid,
                        principalTable: "PerguntaChecklist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SetorPergunta_SetorArea_SetorAreaid",
                        column: x => x.SetorAreaid,
                        principalTable: "SetorArea",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "NaoConformidade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RespostaChecklistid = table.Column<int>(type: "int", nullable: false),
                    ContadorReincidencia = table.Column<int>(type: "int", nullable: false),
                    DataOcorrencia = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DescricaoCausa = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NaoConformidade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NaoConformidade_RespostaChecklist_RespostaChecklistid",
                        column: x => x.RespostaChecklistid,
                        principalTable: "RespostaChecklist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_PerfilAcessoid",
                table: "Usuario",
                column: "PerfilAcessoid");

            migrationBuilder.CreateIndex(
                name: "IX_EvidenciaFotografica_PlanoAcao5W2Hid",
                table: "EvidenciaFotografica",
                column: "PlanoAcao5W2Hid");

            migrationBuilder.CreateIndex(
                name: "IX_NaoConformidade_RespostaChecklistid",
                table: "NaoConformidade",
                column: "RespostaChecklistid");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipanteInspecao_InspecaoISPid",
                table: "ParticipanteInspecao",
                column: "InspecaoISPid");

            migrationBuilder.CreateIndex(
                name: "IX_PerguntaChecklist_CategoriaPerguntoId",
                table: "PerguntaChecklist",
                column: "CategoriaPerguntoId");

            migrationBuilder.CreateIndex(
                name: "IX_RespostaChecklist_InspecaoISPid",
                table: "RespostaChecklist",
                column: "InspecaoISPid");

            migrationBuilder.CreateIndex(
                name: "IX_RespostaChecklist_PerguntaChecklistid",
                table: "RespostaChecklist",
                column: "PerguntaChecklistid");

            migrationBuilder.CreateIndex(
                name: "IX_SetorPergunta_PerguntaChecklistid",
                table: "SetorPergunta",
                column: "PerguntaChecklistid");

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricoPrazo5W2H_PlanoAcao5W2H_PlanoAcao5W2Hid",
                table: "HistoricoPrazo5W2H",
                column: "PlanoAcao5W2Hid",
                principalTable: "PlanoAcao5W2H",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InspecaoISP_SetorArea_SetorAreaid",
                table: "InspecaoISP",
                column: "SetorAreaid",
                principalTable: "SetorArea",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InspecaoISP_Usuario_Usuarioid",
                table: "InspecaoISP",
                column: "Usuarioid",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanoAcao5W2H_NaoConformidade_NaoConformidadeid",
                table: "PlanoAcao5W2H",
                column: "NaoConformidadeid",
                principalTable: "NaoConformidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_PerfilAcesso_PerfilAcessoid",
                table: "Usuario",
                column: "PerfilAcessoid",
                principalTable: "PerfilAcesso",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
