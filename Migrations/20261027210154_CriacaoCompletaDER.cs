using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoISP.Baldan.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoCompletaDER : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

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
                name: "SetorArea",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetorArea", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PerguntaChecklist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TextoPergunta = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CategoriaPerguntoId = table.Column<int>(type: "int", nullable: false),
                    Ativo = table.Column<bool>(type: "tinyint(1)", nullable: false)
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
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Senha = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PerfilAcessoid = table.Column<int>(type: "int", nullable: false),
                    SetorAreaid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_PerfilAcesso_PerfilAcessoid",
                        column: x => x.PerfilAcessoid,
                        principalTable: "PerfilAcesso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuario_SetorArea_SetorAreaid",
                        column: x => x.SetorAreaid,
                        principalTable: "SetorArea",
                        principalColumn: "Id");
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
                name: "InspecaoISP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SetorAreaid = table.Column<int>(type: "int", nullable: false),
                    Usuarioid = table.Column<int>(type: "int", nullable: false),
                    DataInspecao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EhRetroativo = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InspecaoISP", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InspecaoISP_SetorArea_SetorAreaid",
                        column: x => x.SetorAreaid,
                        principalTable: "SetorArea",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InspecaoISP_Usuario_Usuarioid",
                        column: x => x.Usuarioid,
                        principalTable: "Usuario",
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
                    NomeParticipante = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CaminhoFotoEquipe = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
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
                name: "NaoConformidade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RespostaChecklistid = table.Column<int>(type: "int", nullable: false),
                    DescricaoCausa = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataOcorrencia = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ContadorReincidencia = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "PlanoAcao5W2H",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NaoConformidadeid = table.Column<int>(type: "int", nullable: false),
                    OQueSeraFeito = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ComoSeraRealizada = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OndeSeraRealizada = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PrazoLimite = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Responsavel = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustoEstimado = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    JustificativaRecusa = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanoAcao5W2H", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanoAcao5W2H_NaoConformidade_NaoConformidadeid",
                        column: x => x.NaoConformidadeid,
                        principalTable: "NaoConformidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "HistoricoPrazo5W2H",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PlanoAcao5W2Hid = table.Column<int>(type: "int", nullable: false),
                    PrazoAnterior = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    NovoPrazo = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    MotivoAlteracao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataModificacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoPrazo5W2H", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoricoPrazo5W2H_PlanoAcao5W2H_PlanoAcao5W2Hid",
                        column: x => x.PlanoAcao5W2Hid,
                        principalTable: "PlanoAcao5W2H",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_EvidenciaFotografica_PlanoAcao5W2Hid",
                table: "EvidenciaFotografica",
                column: "PlanoAcao5W2Hid");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoPrazo5W2H_PlanoAcao5W2Hid",
                table: "HistoricoPrazo5W2H",
                column: "PlanoAcao5W2Hid");

            migrationBuilder.CreateIndex(
                name: "IX_InspecaoISP_SetorAreaid",
                table: "InspecaoISP",
                column: "SetorAreaid");

            migrationBuilder.CreateIndex(
                name: "IX_InspecaoISP_Usuarioid",
                table: "InspecaoISP",
                column: "Usuarioid");

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
                name: "IX_PlanoAcao5W2H_NaoConformidadeid",
                table: "PlanoAcao5W2H",
                column: "NaoConformidadeid");

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

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_PerfilAcessoid",
                table: "Usuario",
                column: "PerfilAcessoid");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_SetorAreaid",
                table: "Usuario",
                column: "SetorAreaid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EvidenciaFotografica");

            migrationBuilder.DropTable(
                name: "HistoricoPrazo5W2H");

            migrationBuilder.DropTable(
                name: "ParticipanteInspecao");

            migrationBuilder.DropTable(
                name: "SetorPergunta");

            migrationBuilder.DropTable(
                name: "PlanoAcao5W2H");

            migrationBuilder.DropTable(
                name: "NaoConformidade");

            migrationBuilder.DropTable(
                name: "RespostaChecklist");

            migrationBuilder.DropTable(
                name: "InspecaoISP");

            migrationBuilder.DropTable(
                name: "PerguntaChecklist");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "CategoriaPergunta");

            migrationBuilder.DropTable(
                name: "PerfilAcesso");

            migrationBuilder.DropTable(
                name: "SetorArea");
        }
    }
}
