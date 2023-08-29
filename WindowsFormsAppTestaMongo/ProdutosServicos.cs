using System;

namespace WindowsFormsAppTestaMongo
{
    public class ProdutosServicos
    {
        public _Id _id { get; set; }
        public string[] _t { get; set; }
        public string[] InformacoesPesquisa { get; set; }
        public string Versao { get; set; }
        public bool Ativo { get; set; }
        public string CodigoInterno { get; set; }
        public string Descricao { get; set; }
        public Indicadorarredondamentotruncamento IndicadorArredondamentoTruncamento { get; set; }
        public Indicadorproducaopropriaterceiro IndicadorProducaoPropriaTerceiro { get; set; }
        public int DiasPrimeiroContatoPosVenda { get; set; }
        public float PercentualCashback { get; set; }
        public Tipoitem TipoItem { get; set; }
        public Unidademedida UnidadeMedida { get; set; }
        public Unidademedidatributavel UnidadeMedidaTributavel { get; set; }
        public float FatorUnidadeMedidaTributavel { get; set; }
        public Subgruporeferencia SubGrupoReferencia { get; set; }
        public string Hash { get; set; }
        public Alteraco[] Alteracoes { get; set; }
        public bool Vendavel { get; set; }
        public string CodigoBarras { get; set; }
        public Imagem Imagem { get; set; }
        public float PesoLiquido { get; set; }
        public float PesoBruto { get; set; }
        public bool Pesavel { get; set; }
        public Intervalovalidade IntervaloValidade { get; set; }
        public Marca Marca { get; set; }
        public bool Refeicao { get; set; }
        public bool CodigoBarrasArtificial { get; set; }
        public bool InativarSaneamento { get; set; }
        public object[] CodigosBarrasAlternativos { get; set; }
        public Informacaonutricionalreferencia InformacaoNutricionalReferencia { get; set; }
    }

    public class _Id
    {
        public string oid { get; set; }
    }

    public class Indicadorarredondamentotruncamento
    {
        public string _t { get; set; }
    }

    public class Indicadorproducaopropriaterceiro
    {
        public string _t { get; set; }
    }

    public class Tipoitem
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
    }

    public class Unidademedida
    {
        public string _t { get; set; }
        public _Id1 _id { get; set; }
        public string[] InformacoesPesquisa { get; set; }
        public string Descricao { get; set; }
        public string Sigla { get; set; }
    }

    public class _Id1
    {
        public string oid { get; set; }
    }

    public class Unidademedidatributavel
    {
        public string _t { get; set; }
        public _Id2 _id { get; set; }
        public string[] InformacoesPesquisa { get; set; }
        public string Descricao { get; set; }
        public string Sigla { get; set; }
    }

    public class _Id2
    {
        public string oid { get; set; }
    }

    public class Subgruporeferencia
    {
        public string oid { get; set; }
    }

    public class Imagem
    {
        public string binary { get; set; }
        public string type { get; set; }
    }

    public class Intervalovalidade
    {
        public string _t { get; set; }
        public int TempoValidade { get; set; }
    }

    public class Marca
    {
        public string _t { get; set; }
        public _Id3 _id { get; set; }
        public string[] InformacoesPesquisa { get; set; }
        public string Versao { get; set; }
        public bool Ativo { get; set; }
        public string Descricao { get; set; }
        public string DescricaoPesquisaAbcFarma { get; set; }
    }

    public class _Id3
    {
        public string oid { get; set; }
    }

    public class Informacaonutricionalreferencia
    {
        public string oid { get; set; }
    }

    public class Alteraco
    {
        public string _t { get; set; }
        public string ValorAnterior { get; set; }
        public Datainicio DataInicio { get; set; }
        public Datafim DataFim { get; set; }
    }

    public class Datainicio
    {
        public DateTime date { get; set; }
    }

    public class Datafim
    {
        public DateTime date { get; set; }
    }
}