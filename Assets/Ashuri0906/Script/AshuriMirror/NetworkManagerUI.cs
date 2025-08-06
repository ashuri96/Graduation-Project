using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

/// <summary>
/// Mirror�̃l�b�g���[�N�ڑ��𐧌䂷��UI���Ǘ�����N���X
/// </summary>
public class NetworkManagerUI : MonoBehaviour
{
    /// <summary>
    /// �z�X�g/�N���C�A���g/�T�[�o�[�{�^�����z�u����Ă���Canvas
    /// �ڑ����J�n�������\���ɂ��邽�߂Ɏg�p
    /// </summary>
    [Tooltip("�ڑ��{�^���Ȃǂ��z�u����Ă���Canvas�I�u�W�F�N�g")]
    public Canvas canvas;

    /// <summary>
    /// [Host]�{�^���������ꂽ�Ƃ��ɌĂяo�����֐�
    /// </summary>
    public void OnHostButton()
    {
        // ����GameObject�ɃA�^�b�`����Ă���NetworkManager�̋@�\���g���ăz�X�g�Ƃ��ċN������
        // �z�X�g�F�T�[�o�[���N�����A���g���N���C�A���g�Ƃ��Ă��̃T�[�o�[�ɎQ������
        GetComponent<NetworkManager>().StartHost();

        // �ڑ����J�n������A�{�^���������Ȃ��悤��UI���\���ɂ���
        canvas.gameObject.SetActive(false);
    }

    /// <summary>
    /// [Client]�{�^���������ꂽ�Ƃ��ɌĂяo�����֐�
    /// </summary>
    public void OnClientButton()
    {
        // �ڑ���ƂȂ�T�[�o�[��IP�A�h���X���w�肷��
        // "localhost"�͎������g��PC���w�����߁A�e�X�g���ɕ֗�
        GetComponent<NetworkManager>().networkAddress = "localhost";

        // ����GameObject�ɃA�^�b�`����Ă���NetworkManager�̋@�\���g���ăN���C�A���g�Ƃ��ċN������
        // �N���C�A���g�F�w�肵��IP�A�h���X�̃T�[�o�[�ɐڑ������݂�
        GetComponent<NetworkManager>().StartClient();

        // �ڑ����J�n������A�{�^���������Ȃ��悤��UI���\���ɂ���
        canvas.gameObject.SetActive(false);
    }

    /// <summary>
    /// [Server Only]�{�^���������ꂽ�Ƃ��ɌĂяo�����֐�
    /// </summary>
    public void OnServerButton()
    {
        // ����GameObject�ɃA�^�b�`����Ă���NetworkManager�̋@�\���g���ăT�[�o�[�Ƃ��ċN������
        // �T�[�o�[��p�F�v���C���[�Ƃ��Ă͎Q�������A�ڑ���҂��󂯂邾���̃T�[�o�[�𗧂Ă�
        GetComponent<NetworkManager>().StartServer();

        // �ڑ����J�n������A�{�^���������Ȃ��悤��UI���\���ɂ���
        canvas.gameObject.SetActive(false);
    }
}