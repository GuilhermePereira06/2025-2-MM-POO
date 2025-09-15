public class Televisao
{
    public const int VOL_MAX = 100;
    public const int VOL_MIN = 0;
    public const int CANAL_MAX = 520;
    public const int CANAL_MIN = 1;

    public bool ligada;
    public int volume;
    public int canalAtual;
    public int ultimoCanal;
    public bool Volume0;
    public int volumeAntesDoMudo;
    public float tamanho;

    public Televisao(float tamanho)
    {
        this.tamanho = tamanho;
        ligada = false;
        volume = 10;
        canalAtual = CANAL_MIN;
        ultimoCanal = canalAtual;
        Volume0 = false;
        volumeAntesDoMudo = volume;
    }
    public void Ligar()
    {
        ligada = true;
        canalAtual = ultimoCanal;
    }
    public void Desligar()
    {
        ligada = false;
        ultimoCanal = canalAtual;
    }
    public void AumentarVolume()
    {
        if (!ligada)
            return;

        if (Volume0)
        {
            DesativarMudo();
        }

        if (volume < VOL_MAX)
            volume++;
    }
    public void DiminuirVolume()
    {
        if (!ligada)
            return;

        if (Volume0)
        {
            DesativarMudo();
        }

        if (volume > VOL_MIN)
            volume--;
    }
    public void AtivarMudo()
    {
        if (!ligada)
            return;

        if (!Volume0)
        {
            volumeAntesDoMudo = volume;
            volume = 0;
            Volume0 = true;
        }
    }
    public void DesativarMudo()
    {
        if (!ligada)
            return;

        if (Volume0)
        {
            volume = volumeAntesDoMudo;
            Volume0 = false;
        }
    }

    public void AumentarCanal()
    {
        if (!ligada)
            return;

        if (canalAtual < CANAL_MAX)
            canalAtual++;
        else
            canalAtual = CANAL_MIN;
    }

    public void DiminuirCanal()
    {
        if (!ligada)
            return;

        if (canalAtual > CANAL_MIN)
            canalAtual--;
        else
            canalAtual = CANAL_MAX;
    }

    public void EscolherCanal(int numeroCanal)
    {
        if (!ligada)
            return;

        if (numeroCanal >= CANAL_MIN && numeroCanal <= CANAL_MAX)
            canalAtual = numeroCanal;
    }
}


public class Televisao
{
    public const int VOL_MAX = 100;
    public const int VOL_MIN = 0;
    public const int CANAL_MAX = 520;
    public const int CANAL_MIN = 1;

    public bool ligada;
    public int volume;
    public int canalAtual;
    public int ultimoCanal;
    public bool Volume0;
    public int volumeAntesDoMudo;
    public float tamanho;

    public Televisao(float tamanho)
    {
        this.tamanho = tamanho;
        ligada = false;
        volume = 10;
        canalAtual = CANAL_MIN;
        ultimoCanal = canalAtual;
        Volume0 = false;
        volumeAntesDoMudo = volume;
    }
    public void Ligar()
    {
        ligada = true;
        canalAtual = ultimoCanal;
    }
    public void Desligar()
    {
        ligada = false;
        ultimoCanal = canalAtual;
    }
    public void AumentarVolume()
    {
        if (!ligada)
            return;

        if (Volume0)
        {
            DesativarMudo();
        }

        if (volume < VOL_MAX)
            volume++;
    }
    public void DiminuirVolume()
    {
        if (!ligada)
            return;

        if (Volume0)
        {
            DesativarMudo();
        }

        if (volume > VOL_MIN)
            volume--;
    }
    public void AtivarMudo()
    {
        if (!ligada)
            return;

        if (!Volume0)
        {
            volumeAntesDoMudo = volume;
            volume = 0;
            Volume0 = true;
        }
    }
    public void DesativarMudo()
    {
        if (!ligada)
            return;

        if (Volume0)
        {
            volume = volumeAntesDoMudo;
            Volume0 = false;
        }
    }

    public void AumentarCanal()
    {
        if (!ligada)
            return;

        if (canalAtual < CANAL_MAX)
            canalAtual++;
        else
            canalAtual = CANAL_MIN;
    }

    public void DiminuirCanal()
    {
        if (!ligada)
            return;

        if (canalAtual > CANAL_MIN)
            canalAtual--;
        else
            canalAtual = CANAL_MAX;
    }

    public void EscolherCanal(int numeroCanal)
    {
        if (!ligada)
            return;

        if (numeroCanal >= CANAL_MIN && numeroCanal <= CANAL_MAX)
            canalAtual = numeroCanal;
    }
}


